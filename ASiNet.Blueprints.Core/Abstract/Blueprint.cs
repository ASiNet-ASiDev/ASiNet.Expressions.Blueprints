using System.Collections;
using System.Collections.Frozen;
using System.Linq.Expressions;
using System.Reflection;
using ASiNet.Blueprints.Helper;
using ASiNet.Blueprints.Interfaces;

namespace ASiNet.Blueprints.Abstract;
public abstract class Blueprint<T> : IBlueprint<T> where T : Delegate
{
    public Blueprint()
    {
        MethodInfo = ReflectionHelper.MethodInfoFromDelegateType(typeof(T));
        _parameters = ReflectionHelper.InitParameters(MethodInfo).ToFrozenDictionary();
        SourceType = MethodInfo.ReturnType;
        SourceLink = new Link(this);
    }

    public IParameter this[string parameterName] => _parameters[parameterName];

    public Guid NodeId { get; } = Guid.NewGuid();

    public Guid SourceId { get; } = Guid.NewGuid();

    public string SourceName { get; } = "return";

    public Type SourceType { get; }

    public ILink SourceLink { get; }

    public MethodInfo MethodInfo { get; }


    private readonly FrozenDictionary<string, IParameter> _parameters;

    private readonly Dictionary<string, INode> _nodes = [];

    public bool AddNode(INode node)
    {
        throw new NotImplementedException();
    }

    public bool Link(ILinkSource source, ILinkTarget target)
    {
        throw new NotImplementedException();
    }

    public bool RemoveNode(INode node)
    {
        throw new NotImplementedException();
    }

    public abstract Expression Build();

    public abstract T BuildLambda();

    public IEnumerator<IParameter> GetEnumerator() =>
        _parameters.Values.Select(x => x).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() =>
        _parameters.Values.Select(x => x).GetEnumerator();
}
