using System.Collections.Generic;
using Chess.Games;

namespace Chess.Tests.Games
{
	public class GameEventsBag : IDomainChangePipelineElement
	{
		public GameEventsBag(IEnumerable<IDomainEvent> pastEvents)
		{
			Events = new Queue<IDomainEvent>(pastEvents);
		}

		public Queue<IDomainEvent> Events { get; }

		public void Handle(DomainChanges changes)
		{
			foreach (var @event in changes.Events)
			{
				Events.Enqueue(@event);
			}
			
		}
	}
}