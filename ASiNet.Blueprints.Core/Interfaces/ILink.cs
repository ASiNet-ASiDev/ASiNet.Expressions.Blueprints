namespace ASiNet.Blueprints.Interfaces;
public interface ILink : IEnumerable<ILinkTarget>
{

    public ILinkTarget this[Guid targetId] { get; }

    public int TergetsCount { get; }

    public Type ValueType { get; }

    public ILinkSource Source { get; set; }

    public bool AddTarget(ILinkTarget target);

    public bool RemoveTarget(ILinkTarget target);
}
