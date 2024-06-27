using System.Reflection;
using ASiNet.Blueprints.Interfaces;

namespace ASiNet.Blueprints.Helper;
internal static class ReflectionHelper
{
    public static Dictionary<string, IParameter> InitParameters(ConstructorInfo constructorInfo)
    {
        var result = new Dictionary<string, IParameter>();

        foreach (var parameter in constructorInfo.GetParameters())
        {
            var newParameter = new Parameter(parameter);
            result.Add(newParameter.TargetName, newParameter);
        }

        return result;
    }

    public static Dictionary<string, IParameter> InitParameters(MethodInfo methodInfo)
    {
        var result = new Dictionary<string, IParameter>();

        foreach (var parameter in methodInfo.GetParameters())
        {
            var newParameter = new Parameter(parameter);
            result.Add(newParameter.TargetName, newParameter);
        }

        return result;
    }

    public static MethodInfo MethodInfoFromDelegateType(Type deleg) => deleg.GetMethod("Invoke") ?? throw new MissingMethodException();
    

}
