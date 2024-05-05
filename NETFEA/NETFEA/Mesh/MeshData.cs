using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class MeshData
    {
        private FeNodeCollection _nodes;
        private FeElementCollection _elements;
        public MeshData() { 
            _nodes = new FeNodeCollection();
            _elements = new FeElementCollection();
        }
        public void AddNode( FeNode node ) { _nodes.Add(node.Id,node); }
        public void AddNode(int id,double x,double y,double z)
        {
            AddNode(new FeNode(id,x,y,z));
        }
        public void AddElement(FeElement element){_elements.Add(element.Id,element);}

        public FeNode GetNodeByNumber(int number)
        {
            _nodes.TryGetValue(number, out FeNode node);
            return node;
        }
        public FeElement GetElementByNumber(int number)
        {
            _elements.TryGetValue(number, out FeElement element);
            return element;
        }
    }
}
