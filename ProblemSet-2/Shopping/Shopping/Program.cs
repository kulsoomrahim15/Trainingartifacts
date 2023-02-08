using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int[] nm = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int n = nm[0], m = nm[1];
            int[,] graph = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        graph[i, j] = 0;
                    }
                    else
                    {
                        graph[i, j] = int.MaxValue;
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                int[] xyd = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                int x = xyd[0], y = xyd[1], d = xyd[2];
                graph[x, y] = d;
                graph[y, x] = d;
            }
            int s = int.Parse(Console.ReadLine());
            int[] stores = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int distance = 0;
            int current = 0;
            bool[] visited = new bool[n];
            for (int i = 0; i < s; i++)
            {//greedy approach 
                int next = stores[i];
                distance += graph[current, next];
                current = next;
                visited[current] = true;
                int min = int.MaxValue;
                int minIndex = -1;
                for (int j = 0; j < n; j++)
                {
                    if (!visited[j] && graph[current, j] < min)
                    {
                        min = graph[current, j];
                        minIndex = j;
                    }
                }
                if (minIndex == -1)
                {
                    break;
                }




                current = minIndex;
            }
            distance += graph[current, 0];
            Console.WriteLine(distance);
        }
    }
}