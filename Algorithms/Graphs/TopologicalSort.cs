using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using DataStructures.Graphs;

namespace Algorithms.Graphs
{
    public class TopologicalSort
    {
        private readonly GraphOfNodes _graph;

        public TopologicalSort(GraphOfNodes graph)
        {
            _graph = graph;
        }

        // https://leetcode.com/problems/course-schedule/
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var graph = BuildGraph(numCourses, prerequisites);
            var topologicalOrder = new List<GraphNode>();

            var canContinue = true;

            while (canContinue)
            {
                var coursesAvailable = graph.Graph.Where(x => x.Adjacent.Count == 0).ToList();
                if (!coursesAvailable.Any())
                {
                    canContinue = false;
                }

                foreach (var course in coursesAvailable)
                {
                    graph.Graph.Remove(course); // could also mark
                    foreach (var dependentCourse in graph.Graph.Where(x => x.Adjacent.Any(y => y == course)).ToList())
                    {
                        dependentCourse.Adjacent.Remove(course);
                    }
                    topologicalOrder.Add(course);
                }
            }

            if (topologicalOrder.Count == numCourses)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private GraphOfNodes BuildGraph(int numCourses, int[][] prerequisites)
        {
            var graph = new GraphOfNodes();
            for (var x = 0; x < numCourses; x++)
            {
                graph.Graph.Add(new GraphNode(x));
            }

            foreach (var prerequisite in prerequisites)
            {
                var source = graph.Graph.First(x => x.Id == prerequisite[0]);
                var destination = graph.Graph.First(x => x.Id == prerequisite[1]);
                destination.Adjacent.Add(source);
            }

            return graph;
        }
    }
}