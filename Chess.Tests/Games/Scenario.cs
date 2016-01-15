using System.Collections.Generic;
using Chess.Games;

namespace Chess.Tests.Games
{
	public abstract class Scenario<TCommand, TCommandHandler> where TCommandHandler : ICommandHandler<TCommand>
	{
		protected TCommand _when;
		protected EventBag _outcome;

		protected Scenario()
		{
			_outcome = new EventBag(With());
			_when = When();
			Given().Handle(_when);
		}
		public abstract TCommandHandler Given();

		public abstract IEnumerable<IDomainEvent> With();

		public abstract TCommand When();
	}
}