namespace ASiNet.Blueprints.Interfaces;
public interface ILinkSource
{
    public Guid SourceId { get; }
    public string SourceName { get; }

    public Type SourceType { get; }

    public ILink SourceLink { get; }

}
