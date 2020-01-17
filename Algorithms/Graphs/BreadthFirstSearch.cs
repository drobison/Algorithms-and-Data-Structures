using System.Collections.Generic;
using System.Linq;
using DataStructures.Graphs;

namespace Algorithms.Graphs
{
    public class BreadthFirstSearch
    {
        private readonly GraphOfNodes _graph;

        public BreadthFirstSearch(GraphOfNodes graph)
        {
            _graph = graph;
        }

        public bool HasPathBFS(int source, int destination)
        {
            var sourceNode = _graph.GetNode(source);
            var destinationNode = _graph.GetNode(destination);
            var queue = new Queue<GraphNode>();
            var visited = new List<int>();
            queue.Enqueue(sourceNode);
            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (current == destinationNode) return true;

                foreach (var neighbor in current.Adjacent)
                {
                    if (!visited.Contains(neighbor.Id))
                    {
                        queue.Enqueue(neighbor);
                    }
                }
                visited.Add(current.Id);
            }

            return false;
        }
    }
}