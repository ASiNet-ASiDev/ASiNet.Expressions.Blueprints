using System.Collections;
using System.Collections.Frozen;
using System.Linq.Expressions;
using System.Reflection;
using ASiNet.Blueprints.Helper;
using ASiNet.Blueprints.Interfaces;

namespace ASiNet.Blueprints.Abstract;
public abstract class MethodBase : IMethod
{
    protected MethodBase(MethodInfo methodInfo)
    {
        MethodInfo = methodInfo;
        SourceType = methodInfo.ReturnType;
        SourceLink = new Link(this);
        MethodName = methodInfo.Name;
        _parameters = ReflectionHelper.InitParameters(methodInfo).ToFrozenDictionary();
        Instance = new InstanceParameter(methodInfo.DeclaringType!);
    }

    public Guid NodeId { get; } = Guid.NewGuid();
    public Guid SourceId { get; } = Guid.NewGuid();

    public IParameter this[string parameterName] => _parameters[parameterName];

    private readonly FrozenDictionary<string, IParameter> _parameters;

    public string MethodName { get; }

    public MethodInfo MethodInfo { get; }

    public ILinkTarget Instance { get; }

    public string SourceName { get; } = "return";

    public Type SourceType { get; }

    public ILink SourceLink { get; }

    public abstract Expression Build();

    public IEnumerator<IParameter> GetEnumerator() =>
        _parameters.Values.Select(x => x).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() =>
        _parameters.Values.Select(x => x).GetEnumerator();
}
