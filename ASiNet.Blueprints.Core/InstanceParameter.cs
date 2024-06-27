using ASiNet.Blueprints.Interfaces;

namespace ASiNet.Blueprints;
public class InstanceParameter(Type type) : ILinkTarget
{
    public Guid TargetId { get; } = Guid.NewGuid();

    public string TargetName { get; } = "instance";

    public Type TargetType { get; } = type;

    public ILink? TargetLink { get; set; }
}
