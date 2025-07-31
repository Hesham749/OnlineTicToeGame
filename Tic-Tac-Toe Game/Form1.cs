using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private HubConnection con;

		private string _playerName = string.Empty;

		private string _OtherPlayerName = string.Empty;

		private string _currentGroup = string.Empty;

		private bool _IsGameCreator = false;

		private bool _PlayerTurn = false;

		private bool _HaveWinner = false;

		private byte _MoveCounter = 0;

		private enum enChoices : byte
		{
			X = 1, O
		};

		private bool ChangePic(PictureBox Box)
		{
			if (Box.Tag.ToString() == 0.ToString())
			{
				if (_PlayerTurn)
				{
					if (_IsGameCreator)
					{
						Box.Image = Resources.X;
						Box.Tag = enChoices.X;
					}
					else
					{
						Box.Image = Resources.O;
						Box.Tag = enChoices.O;
					}
					return true;
				}
				else
				{
					MessageBox.Show("Not your turn", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}

		private void FreezeGame(bool Freeze = true)
		{
			pb1.Enabled = !Freeze;
			pb2.Enabled = !Freeze;
			pb3.Enabled = !Freeze;
			pb4.Enabled = !Freeze;
			pb5.Enabled = !Freeze;
			pb6.Enabled = !Freeze;
			pb7.Enabled = !Freeze;
			pb8.Enabled = !Freeze;
			pb9.Enabled = !Freeze;
		}

		private void EndResult()
		{
			lblWinner.Text = _HaveWinner ? (_PlayerTurn ? _playerName : _OtherPlayerName) : "Draw";

			lblTurn.Text = "Game Over";

			MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
			FreezeGame();
		}

		private void DrawWinLine(PictureBox pb1, PictureBox pb2, PictureBox pb3)
		{

			pb1.BackColor = Color.GreenYellow;
			pb2.BackColor = Color.GreenYellow;
			pb3.BackColor = Color.GreenYellow;

		}

		private bool CheckResult(PictureBox pb1, PictureBox pb2, PictureBox pb3)
		{
			if (pb1.Tag.ToString() != 0.ToString() && pb1.Tag.ToString() == pb2.Tag.ToString() && pb1.Tag.ToString() == pb3.Tag.ToString())
			{
				DrawWinLine(pb1, pb2, pb3);
				_HaveWinner = true;
				return true;
			}
			return false;
		}

		private void CheckWinner()
		{

			//check rows
			if (CheckResult(pb1, pb2, pb3))
			{
				EndResult();
				return;
			}

			if (CheckResult(pb4, pb5, pb6))
			{
				EndResult();
				return;
			}

			if (CheckResult(pb7, pb8, pb9))
			{
				EndResult();
				return;
			}
			//check cols
			if (CheckResult(pb1, pb4, pb7))
			{
				EndResult();
				return;
			}

			if (CheckResult(pb2, pb5, pb8))
			{
				EndResult();
				return;
			}

			if (CheckResult(pb3, pb6, pb9))
			{
				EndResult();
				return;
			}

			//check x

			if (CheckResult(pb1, pb5, pb9))
			{
				EndResult();
				return;
			}

			if (CheckResult(pb3, pb5, pb7))
			{
				EndResult();
			}
			else
			{
				if (_MoveCounter >= 9)
				{
					EndResult();
				}
			}
		}

		private void pb_Click(object sender, EventArgs e)
		{
			var currentBox = sender as PictureBox;


			if (ChangePic(currentBox))
			{
				con.InvokeAsync("MakeMove", _currentGroup, int.Parse(currentBox.Name.Substring(2)));
				lblTurn.Text = _OtherPlayerName;
				_MoveCounter++;
				CheckWinner();
				_PlayerTurn = false;
			}
		}

		private void ResetPb(PictureBox pb)
		{
			pb.Image = Resources.question_mark_96;
			pb.Tag = 0;
			pb.BackColor = Color.Black;
		}

		private void ResetGame()
		{
			lblWinner.Text = "In Progress";
			_HaveWinner = false;
			_MoveCounter = 0;
			ResetPb(pb1);
			ResetPb(pb2);
			ResetPb(pb3);
			ResetPb(pb4);
			ResetPb(pb5);
			ResetPb(pb6);
			ResetPb(pb7);
			ResetPb(pb8);
			ResetPb(pb9);
			FreezeGame(false);
		}

		private void btnRestart_Click(object sender, EventArgs e) => con.InvokeAsync("RestartGame", _currentGroup);

		private void btnRestart_MouseEnter(object sender, EventArgs e) => btnRestart.BackColor = Color.Green;

		private void btnRestart_MouseLeave(object sender, EventArgs e) => btnRestart.BackColor = Color.Black;

		private void Form1_Load(object sender, EventArgs e)
		{
			FreezeGame();
			con = new HubConnectionBuilder().WithUrl("https://tictoegame.runasp.net/tictoe")
			.WithAutomaticReconnect()
			.Build();

			con.StartAsync();

			con.On<joinStatus, string>("JoinedMember", (x, name)
			=> lbl_join.Invoke(new Action(() =>
			{
				switch (x)
				{
					case joinStatus.Joind:
						lbl_join.Text = "you successfully joined the game";
						_OtherPlayerName = name;
						lblTurn.Invoke(new Action(() => lblTurn.Text = _OtherPlayerName));
						ResetGame();
						FreezeGame(false);
						break;

					case joinStatus.GameNotFound:
						lbl_join.Text = "game not found invalid code";
						break;

					case joinStatus.GameIsFull:
						lbl_join.Text = "game is full";
						break;

					case joinStatus.alreadyJoind:
						lbl_join.Text = "you already joined";
						break;
				}
			})));

			con.On<string>("generateGroup", (x)
				=> txt_generatedGroup
					.Invoke(new Action(() =>
					{
						txt_generatedGroup.Text = x;
						_currentGroup = x;
					})));

			con.On<string, string>("newMember", (x, name) => lbl_join
			.Invoke(new Action(() =>
			{
				lbl_join.Text = x;
				_OtherPlayerName = name;
				lblTurn.Invoke(new Action(() => lblTurn.Text = _playerName));
				FreezeGame(false);
				_PlayerTurn = true;
			})));


			con.On<string, int>("otherPlayerMove", (curr, index) =>
			{
				lblTurn.Invoke(new Action(() => lblTurn.Text = curr));

				_PlayerTurn = true;
				_IsGameCreator = !_IsGameCreator;
				switch (index)
				{
					case 1:
						ChangePic(pb1);
						break;


					case 2:
						ChangePic(pb2);
						break;


					case 3:
						ChangePic(pb3);
						break;


					case 4:
						ChangePic(pb4);
						break;


					case 5:
						ChangePic(pb5);
						break;


					case 6:
						ChangePic(pb6);
						break;


					case 7:
						ChangePic(pb7);
						break;


					case 8:
						ChangePic(pb8);
						break;


					case 9:
						ChangePic(pb9);
						break;

				}

				_PlayerTurn = false;
				_MoveCounter++;
				CheckWinner();
				_PlayerTurn = true;
				_IsGameCreator = !_IsGameCreator;

			});


			con.On("restartGame", () => ResetGame());

		}



		private void btn_GenerateGame_Click(object sender, EventArgs e)
		{

			if (NameSubmited())
			{
				ResetGame();
				FreezeGame();

				con.InvokeAsync("GenerateGroup", txt_name.Text);
				_IsGameCreator = true;
				_currentGroup = txt_generatedGroup.Text;
			}
			else
			{
				MessageBox.Show("Please submit your name first", "Name is empty", MessageBoxButtons.OK);
			}
		}

		private void btn_joinGame_Click(object sender, EventArgs e)
		{
			if (NameSubmited())
			{
				con.InvokeAsync("JoinGroup", txt_name.Text, txt_joinGroup.Text);
				_IsGameCreator = false;
				_currentGroup = txt_joinGroup.Text;
			}
			else
			{
				MessageBox.Show("Please submit your name first", "Name is empty", MessageBoxButtons.OK);
			}
		}


		private bool NameSubmited() => !string.IsNullOrWhiteSpace(_playerName);


		private void btn_name_Click(object sender, EventArgs e)
		{
			_playerName = txt_name.Text;

			txt_name.Enabled = false;
			btn_name.Enabled = false;
		}
	}
}