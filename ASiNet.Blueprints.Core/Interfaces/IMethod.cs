using System.Reflection;

namespace ASiNet.Blueprints.Interfaces;
public interface IMethod : INode, ILinkSource, IEnumerable<IParameter>
{
    public string MethodName { get; }

    public MethodInfo MethodInfo { get; }

    public IParameter this[string parameterName] { get; }

    public ILinkTarget Instance { get; }
}
