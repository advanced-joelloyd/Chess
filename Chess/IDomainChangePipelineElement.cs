using Chess.Games;

namespace Chess
{
	public interface IDomainChangePipelineElement
	{
		void Handle(DomainChanges changes);
	}
}