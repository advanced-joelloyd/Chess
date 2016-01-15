using System;

namespace Chess.Games
{
	public struct NewGameCreated : IDomainEvent
	{
		public NewGameCreated(Guid gameId) : this()
		{
			GameId = gameId;
		}

		public Guid GameId { get; private set; }
	}
}