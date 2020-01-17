using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class GraphNode
    {
        public int Id { get; set; }
        public List<GraphNode> Adjacent { get; set; }

        public GraphNode(int id)
        {
            Id = id;
            Adjacent = new List<GraphNode>();
        }
    }
}