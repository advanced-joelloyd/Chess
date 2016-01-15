namespace Chess.Games
{
	public interface ICommandHandler<in TCommand>
	{
		void Handle(TCommand command);
	}
}