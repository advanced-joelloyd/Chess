using System.Collections.Generic;

namespace Chess.Games
{
	public class DomainChanges
	{
		public DomainChanges(params IDomainEvent[] events)
		{
			Events = events;
		}

		public IEnumerable<IDomainEvent> Events { get; }
	}
}