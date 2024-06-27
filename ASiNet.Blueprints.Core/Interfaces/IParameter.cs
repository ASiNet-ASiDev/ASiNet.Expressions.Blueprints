using System.Reflection;

namespace ASiNet.Blueprints.Interfaces;
public interface IParameter : ILinkTarget
{
    public ParameterInfo ParameterInfo { get; }
}
