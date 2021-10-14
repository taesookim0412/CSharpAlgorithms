using System.Collections.Generic;

namespace CSharpAlgorithms.Difficulties.Medium
{
    //TLE
    public class CourseSchedule {
        public bool CanFinish(int numCourses, int[][] prerequisites) {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            foreach (int[] prereq in prerequisites){
                int course = prereq[0], req = prereq[1];
                if (!graph.ContainsKey(course)){
                    graph[course] = new List<int>{req};
                }
                else{
                    graph[course].Add(req);
                }
            }
            for (int i = 0; i < numCourses; i++){
                if (!dfs(graph, new HashSet<int>(), i)){
                    return false;
                }
            }
            return true;
        }
        public bool dfs(Dictionary<int, List<int>> graph, HashSet<int> visited, int course){
            if (visited.Contains(course)){
                return false;
            }
            if (!graph.ContainsKey(course)){
                return true;
            }
            foreach (int prereq in graph[course]){
                visited.Add(course);
                if (!dfs(graph, visited, prereq))
                {
                    return false;
                }
                visited.Remove(course);
            }
            return true;
        }
    }
}