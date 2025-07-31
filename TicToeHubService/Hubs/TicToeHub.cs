using Microsoft.AspNetCore.SignalR;

namespace TicToeHubService.Hubs;

public class TicToeHub : Hub
{
	private readonly TicToeHubGroups _ticToeHubGroups;

	public TicToeHub(TicToeHubGroups ticToeHubGroups) => _ticToeHubGroups = ticToeHubGroups;

	public void GenerateGroup(string name)
	{
		ClearMemmory();
		string groupName = Guid.NewGuid().ToString();

		Groups.AddToGroupAsync(Context.ConnectionId, groupName);

		_ticToeHubGroups.CurrentGroups.TryAdd(groupName, [new() { id = Context.ConnectionId, name = name }]);

		Clients.Caller.SendAsync("generateGroup", groupName);
	}

	public void JoinGroup(string name, string groupName)
	{
		//ClearMemmory();

		if (_ticToeHubGroups.CurrentGroups.TryGetValue(groupName, out var group))
		{
			if (group.Exists(x => x.id.Equals(Context.ConnectionId)))
			{
				Clients.Caller.SendAsync("JoinedMember", joinStatus.alreadyJoind, "");
			}
			else if (group.Count < 2)
			{
				ClearMemmory();
				group.Add(new() { id = Context.ConnectionId, name = name });

				string CreatorName = group[0].name;

				Groups.AddToGroupAsync(Context.ConnectionId, groupName);

				Clients.OthersInGroup(groupName).SendAsync("newMember", $"{name} has joined", name);

				Clients.Caller.SendAsync("JoinedMember", joinStatus.Joind, CreatorName);
			}
			else
			{
				Clients.Caller.SendAsync("JoinedMember", joinStatus.GameIsFull, name);
			}
		}
		else
		{
			Clients.Caller.SendAsync("JoinedMember", joinStatus.GameNotFound, name);
		}


	}

	public void MakeMove(string gName, int boxIndex)
	{
		if (_ticToeHubGroups.CurrentGroups.TryGetValue(gName, out var group))
		{
			var currentPlayer = group
				.FirstOrDefault(x => x.id.Equals(Context.ConnectionId));

			if (currentPlayer is not null)
			{

				var otherPlayer = group
				.FirstOrDefault(x => !x.id.Equals(Context.ConnectionId));


				Clients.OthersInGroup(gName).SendAsync("otherPlayerMove", otherPlayer!.name, boxIndex);

			}

		}

	}

	public void RestartGame(string gName) => Clients.Group(gName).SendAsync("restartGame");


	public override Task OnDisconnectedAsync(Exception? exception)
	{
		ClearMemmory();

		return base.OnDisconnectedAsync(exception);
	}

	private void ClearMemmory()
	{
		var groups = new List<string>();

		foreach (var item in _ticToeHubGroups.CurrentGroups)
		{

			item.Value.RemoveAll(x => x.id.Equals(Context.ConnectionId));

			if (item.Value.Count < 1)
				groups.Add(item.Key);
		}

		groups.ForEach(x => _ticToeHubGroups.CurrentGroups.Remove(x, out var _));
	}
}