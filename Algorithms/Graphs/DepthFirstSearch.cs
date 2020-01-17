using System.Collections.Generic;
using DataStructures.Graphs;

namespace Algorithms.Graphs
{
    public class DepthFirstSearch
    {
        private readonly GraphOfNodes _graph;

        public DepthFirstSearch(GraphOfNodes graph)
        {
            _graph = graph;
        }
        public bool HasPathDFS(int source, int destination)
        {
            var sourceNode = _graph.GetNode(source);
            var destinationNode = _graph.GetNode(destination);
            var visited = new HashSet<int>();
            return HasPathDFS(sourceNode, destinationNode, visited);
        }

        private bool HasPathDFS(GraphNode sourceNode, GraphNode destinationNode, HashSet<int> visited)
        {
            if (visited.Contains(sourceNode.Id)) return false;

            if (sourceNode == destinationNode) return true;

            foreach (var neighbor in sourceNode.Adjacent)
            {
                HasPathDFS(neighbor, destinationNode, visited);
            }

            visited.Add(sourceNode.Id);
            return false;
        }
    }
}
