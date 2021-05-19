using System.Collections.Generic;

namespace CTCI.Ch_04_Trees.Task_07_Project_Dependencies
{
    public class ProjectDependencies
    {
        private sealed class ProjectNode
        {
            public ProjectNode(string name)
            {
                Name = name;
            }

            public string Name { get; }
            public bool Built { get; set; }
            public List<ProjectNode> Dependencies { get; } = new();
            public List<ProjectNode> Dependent { get; } = new();
        }

        public IList<string> GetBuildOrder(IList<string> projects, IList<(string, string)> dependencies)
        {
            var projectNodes = new Dictionary<string, ProjectNode>();

            foreach (var project in projects)
            {
                projectNodes[project] = new ProjectNode(project);
            }

            foreach (var (project, dependency) in dependencies)
            {
                var projectNode = projectNodes[project];
                var dependencyNode = projectNodes[dependency];

                dependencyNode.Dependent.Add(projectNode);
                projectNode.Dependencies.Add(dependencyNode);
            }

            var order = new List<string>(projects.Count);

            foreach (var node in projectNodes.Values)
            {
                if (node.Dependent.Count == 0)
                {
                    var success = Traverse(node, new HashSet<ProjectNode>(), order);

                    if (!success)
                    {
                        return null;
                    }
                }
            }

            return order;
        }

        private static bool Traverse(ProjectNode node, HashSet<ProjectNode> visitedNodes, List<string> order)
        {
            if (node.Built)
            {
                return true;
            }

            if (!visitedNodes.Add(node))
            {
                return false;
            }

            foreach (var child in node.Dependencies)
            {
                if (!Traverse(child, visitedNodes, order))
                {
                    return false;
                }
            }

            node.Built = true;
            order.Add(node.Name);

            return true;
        }
    }
}