using System.Linq.Expressions;
using System.Reflection;
using ASiNet.Blueprints.Interfaces;

namespace ASiNet.Blueprints.Abstract;
public abstract class PropertyAccessBase : IPropertyAccess
{
    protected PropertyAccessBase(PropertyInfo info)
    {
        TargetId = SourceId = Guid.NewGuid();
        Instance = new InstanceParameter(info.DeclaringType!);
        SourceType = TargetType = info.PropertyType;
        SourceLink = new Link(this);
    }

    public Guid NodeId { get; } = Guid.NewGuid();

    public ILinkTarget Instance { get; }

    public Guid SourceId { get; }

    public string SourceName { get; } = "get";

    public Type SourceType { get; }

    public ILink SourceLink { get; }

    public Guid TargetId { get; }

    public string TargetName { get; } = "set";

    public Type TargetType { get; }

    public ILink? TargetLink { get; set; }

    public abstract Expression Build();
}
