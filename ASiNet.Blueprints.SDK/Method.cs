using System.Linq.Expressions;
using System.Reflection;

namespace ASiNet.Blueprints.SDK;
public class Method(MethodInfo method) : Abstract.MethodBase(method)
{
    public override Expression Build()
    {
        throw new NotImplementedException();
    }
}
