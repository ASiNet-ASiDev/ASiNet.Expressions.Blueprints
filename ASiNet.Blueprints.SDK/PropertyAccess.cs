using System.Linq.Expressions;
using System.Reflection;
using ASiNet.Blueprints.Abstract;

namespace ASiNet.Blueprints.SDK;
public class PropertyAccess(PropertyInfo propertyInfo) : PropertyAccessBase(propertyInfo)
{
    public override Expression Build()
    {
        throw new NotImplementedException();
    }
}
