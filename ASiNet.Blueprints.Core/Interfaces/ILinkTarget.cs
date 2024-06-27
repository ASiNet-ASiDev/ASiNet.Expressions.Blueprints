namespace ASiNet.Blueprints.Interfaces;
public interface ILinkTarget
{
    public Guid TargetId { get; }
    public string TargetName { get; }

    public Type TargetType { get; }

    public ILink? TargetLink { get; set; }

}
