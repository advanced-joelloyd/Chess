using System;
using System.Collections.Generic;
using Chess.Games;
using Xunit;

namespace Chess.Tests.Games
{
	public class StartingANewGame
	{
		private readonly Queue<IDomainEvent> _actualEvents;
		private readonly CreateNewGame _when;

		public StartingANewGame()
		{
			var gameEvents = new GameEventsBag(Given());

			_when = When();
			new GameCommandHandler(gameEvents).Handle(_when);

			_actualEvents = gameEvents.Events;
		}

		private static IEnumerable<IDomainEvent> Given()
		{
			yield break;
		}

		private CreateNewGame When()
		{
			return new CreateNewGame(gameId: Guid.NewGuid());
		}

		[Fact]
		public void NewGameIsCreated()
		{
			var created = (NewGameCreated) _actualEvents.Dequeue();
			Assert.Equal(_when.GameId, created.GameId);
		}
	}
}
