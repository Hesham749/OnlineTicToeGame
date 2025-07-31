using System.Collections.Concurrent;

namespace TicToeHubService.Hubs;

public class TicToeHubGroups
{
	public ConcurrentDictionary<string, List<Player>> CurrentGroups { get; } = [];

}