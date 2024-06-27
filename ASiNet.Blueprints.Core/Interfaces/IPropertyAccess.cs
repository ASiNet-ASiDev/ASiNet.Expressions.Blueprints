using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASiNet.Blueprints.Interfaces;
public interface IPropertyAccess : INode, ILinkSource, ILinkTarget
{
    public ILinkTarget Instance { get; }


}
