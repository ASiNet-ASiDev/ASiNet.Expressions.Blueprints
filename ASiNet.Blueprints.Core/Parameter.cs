using System.Reflection;
using ASiNet.Blueprints.Interfaces;

namespace ASiNet.Blueprints;
public class Parameter(ParameterInfo parameterInfo) : IParameter
{
    public ParameterInfo ParameterInfo { get; } = parameterInfo;

    public Guid TargetId { get; } = Guid.NewGuid();

    public string TargetName { get; } = parameterInfo.Name is null ? $"param_{parameterInfo.Position}" : parameterInfo.Name;

    public Type TargetType { get; } = parameterInfo.ParameterType;

    public ILink? TargetLink { get; set; }
}
