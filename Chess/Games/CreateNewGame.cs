using System;

namespace Chess.Games
{
	public struct CreateNewGame
	{
		public CreateNewGame(Guid gameId)
		{
			GameId = gameId;
		}

		public Guid GameId { get; }
	}
}