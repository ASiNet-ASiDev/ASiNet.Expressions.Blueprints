using System.Linq.Expressions;

namespace ASiNet.Blueprints.Interfaces;
public interface INode
{
    public Guid NodeId { get; }
    public Expression Build();
}
