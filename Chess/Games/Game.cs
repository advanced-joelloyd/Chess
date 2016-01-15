using System;
using System.Collections.Generic;

namespace Chess.Games
{
	public class Game
	{
		private readonly Queue<IDomainEvent> _changes = new Queue<IDomainEvent>();

		public Game(Guid gameId)
		{
			ApplyChange(new NewGameCreated(gameId));
		}

		private void ApplyChange(NewGameCreated newGameCreated)
		{
			_changes.Enqueue(newGameCreated);
		}

		public DomainChanges GetChanges()
		{
			return new DomainChanges(_changes.ToArray());
		}
	}
}