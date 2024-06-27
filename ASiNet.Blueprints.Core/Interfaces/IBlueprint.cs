using System.Reflection;

namespace ASiNet.Blueprints.Interfaces;
public interface IBlueprint<T> : INode, ILinkSource, IEnumerable<IParameter> where T : Delegate
{
    public IParameter this[string parameterName] { get; }

    public MethodInfo MethodInfo { get; }

    public bool AddNode(INode node);

    public bool RemoveNode(INode node);

    public bool Link(ILinkSource source, ILinkTarget target);

    public T BuildLambda();
}
