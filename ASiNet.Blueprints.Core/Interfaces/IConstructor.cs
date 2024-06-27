using System.Reflection;

namespace ASiNet.Blueprints.Interfaces;
public interface IConstructor : INode, ILinkSource, IEnumerable<IParameter>
{

    public ConstructorInfo ConstructorInfo { get; }

    public IParameter this[string parameterName] { get; }
}
