namespace Chess.Games
{
	public class GameCommandHandler
	{
		private readonly IDomainChangePipelineElement _pipeline;

		public GameCommandHandler(IDomainChangePipelineElement pipeline)
		{
			_pipeline = pipeline;
		}

		public void Handle(CreateNewGame command)
		{
			_pipeline.Handle(new NewGameCreated(gameId: command.GameId));
		}
	}
}