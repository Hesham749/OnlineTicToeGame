namespace Tic_Tac_Toe_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTurn = new System.Windows.Forms.Label();
			this.lblWinner = new System.Windows.Forms.Label();
			this.btnRestart = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.pb1 = new System.Windows.Forms.PictureBox();
			this.pb4 = new System.Windows.Forms.PictureBox();
			this.pb2 = new System.Windows.Forms.PictureBox();
			this.pb3 = new System.Windows.Forms.PictureBox();
			this.pb7 = new System.Windows.Forms.PictureBox();
			this.pb5 = new System.Windows.Forms.PictureBox();
			this.pb6 = new System.Windows.Forms.PictureBox();
			this.pb8 = new System.Windows.Forms.PictureBox();
			this.pb9 = new System.Windows.Forms.PictureBox();
			this.lbl_join = new System.Windows.Forms.Label();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_joinGroup = new System.Windows.Forms.TextBox();
			this.btn_name = new System.Windows.Forms.Button();
			this.btn_joinGame = new System.Windows.Forms.Button();
			this.btn_GenerateGame = new System.Windows.Forms.Button();
			this.txt_generatedGroup = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(16, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Turn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(16, 266);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Winner";
			// 
			// lblTurn
			// 
			this.lblTurn.AutoSize = true;
			this.lblTurn.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurn.ForeColor = System.Drawing.SystemColors.Control;
			this.lblTurn.Location = new System.Drawing.Point(16, 230);
			this.lblTurn.Name = "lblTurn";
			this.lblTurn.Size = new System.Drawing.Size(126, 33);
			this.lblTurn.TabIndex = 2;
			this.lblTurn.Text = "Player 1";
			// 
			// lblWinner
			// 
			this.lblWinner.AutoSize = true;
			this.lblWinner.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWinner.ForeColor = System.Drawing.Color.LawnGreen;
			this.lblWinner.Location = new System.Drawing.Point(16, 302);
			this.lblWinner.Name = "lblWinner";
			this.lblWinner.Size = new System.Drawing.Size(173, 33);
			this.lblWinner.TabIndex = 3;
			this.lblWinner.Text = "In Progress";
			// 
			// btnRestart
			// 
			this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestart.ForeColor = System.Drawing.SystemColors.Control;
			this.btnRestart.Location = new System.Drawing.Point(16, 338);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new System.Drawing.Size(181, 44);
			this.btnRestart.TabIndex = 4;
			this.btnRestart.Text = "Restart Game";
			this.btnRestart.UseVisualStyleBackColor = false;
			this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
			this.btnRestart.MouseEnter += new System.EventHandler(this.btnRestart_MouseEnter);
			this.btnRestart.MouseLeave += new System.EventHandler(this.btnRestart_MouseLeave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(480, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(333, 42);
			this.label5.TabIndex = 5;
			this.label5.Text = "Tic-Tac-Toe Game";
			// 
			// pb1
			// 
			this.pb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
			this.pb1.Location = new System.Drawing.Point(411, 76);
			this.pb1.Name = "pb1";
			this.pb1.Size = new System.Drawing.Size(144, 91);
			this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb1.TabIndex = 6;
			this.pb1.TabStop = false;
			this.pb1.Tag = "0";
			this.pb1.Click += new System.EventHandler(this.pb_Click);
			// 
			// pb4
			// 
			this.pb4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
			this.pb4.Location = new System.Drawing.Point(411, 176);
			this.pb4.Name = "pb4";
			this.pb4.Size = new System.Drawing.Size(144, 91);
			this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb4.TabIndex = 7;
			this.pb4.TabStop = false;
			this.pb4.Tag = "0";
			this.pb4.Click += new System.EventHandler(this.pb_Click);
			// 
			// pb2
			// 
			this.pb2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
			this.pb2.Location = new System.Drawing.Point(565, 76);
			this.pb2.Name = "pb2";
			this.pb2.Size = new System.Drawing.Size(144, 91);
			this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb2.TabIndex = 8;
			this.pb2.TabStop = false;
			this.pb2.Tag = "0";
			this.pb2.Click += new System.EventHandler(this.pb_Click);
			// 
			// pb3
			// 
			this.pb3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
			this.pb3.Location = new System.Drawing.Point(718, 76);
			this.pb3.Name = "pb3";
			this.pb3.Size = new System.Drawing.Size(144, 91);
			this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb3.TabIndex = 9;
			this.pb3.TabStop = false;
			this.pb3.Tag = "0";
			this.pb3.Click += new System.EventHandler(this.pb_Click);
			// 
			// pb7
			// 
			this.pb7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
			this.pb7.Location = new System.Drawing.Point(411, 279);
			this.pb7.Name = "pb7";
			this.pb7.Size = new System.Drawing.Size(144, 91);
			this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb7.TabIndex = 10;
			this.pb7.TabStop = false;
			this.pb7.Tag = "0";
			this.pb7.Click += new System.EventHandler(this.pb_Click);
			// 
			// pb5
			// 
			this.pb5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
			this.pb5.Location = new System.Drawing.Point(565, 176);
			this.pb5.Name = "pb5";
			this.pb5.Size = new System.Drawing.Size(144, 91);
			this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb5.TabIndex = 11;
			this.pb5.TabStop = false;
			this.pb5.Tag = "0";
			this.pb5.Click += new System.EventHandler(this.pb_Click);
			// 
			// pb6
			// 
			this.pb6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
			this.pb6.Location = new System.Drawing.Point(718, 176);
			this.pb6.Name = "pb6";
			this.pb6.Size = new System.Drawing.Size(144, 91);
			this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb6.TabIndex = 12;
			this.pb6.TabStop = false;
			this.pb6.Tag = "0";
			this.pb6.Click += new System.EventHandler(this.pb_Click);
			// 
			// pb8
			// 
			this.pb8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
			this.pb8.Location = new System.Drawing.Point(565, 279);
			this.pb8.Name = "pb8";
			this.pb8.Size = new System.Drawing.Size(144, 91);
			this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb8.TabIndex = 13;
			this.pb8.TabStop = false;
			this.pb8.Tag = "0";
			this.pb8.Click += new System.EventHandler(this.pb_Click);
			// 
			// pb9
			// 
			this.pb9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
			this.pb9.Location = new System.Drawing.Point(718, 279);
			this.pb9.Name = "pb9";
			this.pb9.Size = new System.Drawing.Size(144, 91);
			this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb9.TabIndex = 14;
			this.pb9.TabStop = false;
			this.pb9.Tag = "0";
			this.pb9.Click += new System.EventHandler(this.pb_Click);
			// 
			// lbl_join
			// 
			this.lbl_join.AutoSize = true;
			this.lbl_join.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_join.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl_join.Location = new System.Drawing.Point(30, 25);
			this.lbl_join.Name = "lbl_join";
			this.lbl_join.Size = new System.Drawing.Size(196, 23);
			this.lbl_join.TabIndex = 15;
			this.lbl_join.Text = "Welcome in our Game";
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(12, 77);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(240, 20);
			this.txt_name.TabIndex = 16;
			// 
			// txt_joinGroup
			// 
			this.txt_joinGroup.Location = new System.Drawing.Point(12, 123);
			this.txt_joinGroup.Name = "txt_joinGroup";
			this.txt_joinGroup.Size = new System.Drawing.Size(240, 20);
			this.txt_joinGroup.TabIndex = 17;
			// 
			// btn_name
			// 
			this.btn_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_name.Location = new System.Drawing.Point(277, 77);
			this.btn_name.Name = "btn_name";
			this.btn_name.Size = new System.Drawing.Size(112, 23);
			this.btn_name.TabIndex = 18;
			this.btn_name.Text = "Submit Name";
			this.btn_name.UseVisualStyleBackColor = true;
			this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
			// 
			// btn_joinGame
			// 
			this.btn_joinGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_joinGame.Location = new System.Drawing.Point(277, 120);
			this.btn_joinGame.Name = "btn_joinGame";
			this.btn_joinGame.Size = new System.Drawing.Size(112, 23);
			this.btn_joinGame.TabIndex = 19;
			this.btn_joinGame.Text = "Join Game";
			this.btn_joinGame.UseVisualStyleBackColor = true;
			this.btn_joinGame.Click += new System.EventHandler(this.btn_joinGame_Click);
			// 
			// btn_GenerateGame
			// 
			this.btn_GenerateGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_GenerateGame.Location = new System.Drawing.Point(277, 160);
			this.btn_GenerateGame.Name = "btn_GenerateGame";
			this.btn_GenerateGame.Size = new System.Drawing.Size(112, 23);
			this.btn_GenerateGame.TabIndex = 20;
			this.btn_GenerateGame.Text = "Create Game";
			this.btn_GenerateGame.UseVisualStyleBackColor = true;
			this.btn_GenerateGame.Click += new System.EventHandler(this.btn_GenerateGame_Click);
			// 
			// txt_generatedGroup
			// 
			this.txt_generatedGroup.Location = new System.Drawing.Point(12, 163);
			this.txt_generatedGroup.Name = "txt_generatedGroup";
			this.txt_generatedGroup.Size = new System.Drawing.Size(240, 20);
			this.txt_generatedGroup.TabIndex = 21;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(411, 166);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(451, 10);
			this.progressBar1.TabIndex = 22;
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(411, 268);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(451, 10);
			this.progressBar2.TabIndex = 23;
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(555, 76);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(10, 294);
			this.progressBar3.TabIndex = 24;
			// 
			// progressBar4
			// 
			this.progressBar4.Location = new System.Drawing.Point(708, 76);
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(10, 294);
			this.progressBar4.TabIndex = 25;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(880, 399);
			this.Controls.Add(this.progressBar4);
			this.Controls.Add(this.progressBar3);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.txt_generatedGroup);
			this.Controls.Add(this.btn_GenerateGame);
			this.Controls.Add(this.btn_joinGame);
			this.Controls.Add(this.btn_name);
			this.Controls.Add(this.txt_joinGroup);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.lbl_join);
			this.Controls.Add(this.pb9);
			this.Controls.Add(this.pb8);
			this.Controls.Add(this.pb6);
			this.Controls.Add(this.pb5);
			this.Controls.Add(this.pb7);
			this.Controls.Add(this.pb3);
			this.Controls.Add(this.pb2);
			this.Controls.Add(this.pb4);
			this.Controls.Add(this.pb1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnRestart);
			this.Controls.Add(this.lblWinner);
			this.Controls.Add(this.lblTurn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
		private System.Windows.Forms.Label lbl_join;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_joinGroup;
		private System.Windows.Forms.Button btn_name;
		private System.Windows.Forms.Button btn_joinGame;
		private System.Windows.Forms.Button btn_GenerateGame;
		private System.Windows.Forms.TextBox txt_generatedGroup;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.ProgressBar progressBar4;
	}
}

