using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Graphs
{
    // Todo make generic instead of concrete int implementation

    public class GraphOfNodes
    {
        public List<GraphNode> Graph { get; set; }

        public GraphOfNodes()
        {
            Graph = new List<GraphNode>();
        }
        public GraphNode GetNode(int id)
        {
            return Graph.FirstOrDefault(x => x.Id == id);
        }

        public void AddEdge(int source, int destination)
        {
            var sourceNode = GetNode(source);
            var destinationNode = GetNode(destination);
            sourceNode.Adjacent.Add(destinationNode);
        }
    }
}
