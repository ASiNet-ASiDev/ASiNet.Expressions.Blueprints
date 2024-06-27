using System.Linq.Expressions;
using System.Reflection;
using ASiNet.Blueprints.Abstract;

namespace ASiNet.Blueprints.SDK;
public class Constructor(ConstructorInfo constructorInfo) : ConstructorBase(constructorInfo)
{
    public override Expression Build()
    {
        throw new NotImplementedException();
    }
}
