using System.Collections;
using System.Collections.Frozen;
using System.Linq.Expressions;
using System.Reflection;
using ASiNet.Blueprints.Helper;
using ASiNet.Blueprints.Interfaces;

namespace ASiNet.Blueprints.Abstract;
public abstract class ConstructorBase : IConstructor
{
    protected ConstructorBase(ConstructorInfo constructor)
    {
        ConstructorInfo = constructor;
        SourceType = constructor.DeclaringType!;
        SourceLink = new Link(this);
        _parameters = ReflectionHelper.InitParameters(constructor).ToFrozenDictionary();
    }

    public Guid NodeId { get; } = Guid.NewGuid();

    public Guid SourceId { get; } = Guid.NewGuid();

    public IParameter this[string parameterName] => _parameters[parameterName];

    private readonly FrozenDictionary<string, IParameter> _parameters;

    public ConstructorInfo ConstructorInfo { get; }

    public string SourceName => "instance";

    public Type SourceType { get; }

    public ILink SourceLink { get; }

    public abstract Expression Build();

    public IEnumerator<IParameter> GetEnumerator() =>
        _parameters.Values.Select(x => x).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() =>
        _parameters.Values.Select(x => x).GetEnumerator();
}
