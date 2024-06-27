using System.Collections;
using ASiNet.Blueprints.Interfaces;

namespace ASiNet.Blueprints;
public class Link(ILinkSource source) : ILink
{
    public Type ValueType { get; } = source.SourceType;

    public ILinkSource Source { get; set; } = source;

    public int TergetsCount => _targets.Count;

    public ILinkTarget this[Guid targetId] => _targets[targetId];

    private readonly Dictionary<Guid, ILinkTarget> _targets = [];

    public bool AddTarget(ILinkTarget target)
    {
        if(Source.SourceId == target.TargetId)
            return false;
        if (_targets.TryAdd(target.TargetId, target))
        {
            target.TargetLink = this;
            return true;
        }
        return false;
    }

    public bool RemoveTarget(ILinkTarget target)
    {
        if (Source.SourceId == target.TargetId)
            return false;
        if (_targets.Remove(target.TargetId))
        {
            target.TargetLink = null;
            return true;
        }
        return false;
    }

    public IEnumerator<ILinkTarget> GetEnumerator() =>
        _targets.Values.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() =>
         _targets.Values.GetEnumerator();
}
