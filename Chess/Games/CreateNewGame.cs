using System;

namespace Chess.Games
{
	public class CreateNewGame
	{
		public CreateNewGame(Guid gameId)
		{
			GameId = gameId;
		}

		public Guid GameId { get; }
	}
}