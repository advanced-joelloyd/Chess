using System;
using System.Collections.Generic;
using Chess.Games;
using Xunit;

namespace Chess.Tests.Games
{
	public class StartingANewGame : Scenario<CreateNewGame, GameCommandHandler>
	{
		public override GameCommandHandler Given()
		{
			return new GameCommandHandler(_outcome);
		}

		public override IEnumerable<IDomainEvent> With()
		{
			yield break;
		}

		public override CreateNewGame When()
		{
			return new CreateNewGame(gameId: Guid.NewGuid());
		}

		[Fact]
		public void ThenNewGameIsCreated()
		{
			var created = (NewGameCreated)_outcome.Events.Dequeue();
			Assert.Equal(_when.GameId, created.GameId);
		}
	}
}
