namespace Chess.Games
{
	public class GameCommandHandler : ICommandHandler<CreateNewGame>
	{
		private readonly IDomainChangePipelineElement _pipeline;

		public GameCommandHandler(IDomainChangePipelineElement pipeline)
		{
			_pipeline = pipeline;
		}

		public void Handle(CreateNewGame command)
		{
			var newGame = new Game(gameId: command.GameId);
			_pipeline.Handle(newGame.GetChanges());
		}
	}
}