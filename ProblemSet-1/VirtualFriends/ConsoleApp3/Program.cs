using System;
using System.Collections.Generic;

namespace VirtualFriends
{
    class UnionFind
    {
        public Dictionary<string, string> parents;
        private Dictionary<string, int> sizes;

        public UnionFind()
        {
            parents = new Dictionary<string, string>();
            sizes = new Dictionary<string, int>();
        }

        public void MakeSet(string name)
        {
            parents[name] = name;
            sizes[name] = 1;
        }

        
        //finding root node
        public string Find(string name)
        {//recursively finding the root node 
            if (parents[name] != name)
            {
                parents[name] = Find(parents[name]);
            }
            return parents[name];
        }

        public void Union(string name1, string name2)
        {
            string root1 = Find(name1);
            string root2 = Find(name2);
            if (root1 != root2)
            {
                if (sizes[root1] < sizes[root2])
                {
                    string temp = root1;
                    root1 = root2;
                    root2 = temp;
                }
                parents[root2] = root1;
                sizes[root1] += sizes[root2];
                sizes.Remove(root2);
            }
        }

        public int GetSize(string name)
        {
            return sizes[Find(name)];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int F = int.Parse(Console.ReadLine());
                UnionFind uf = new UnionFind();
                for (int j = 0; j < F; j++)
                {
                    string[] line = Console.ReadLine().Split();
                    string name1 = line[0];
                    string name2 = line[1];
                    if (!uf.parents.ContainsKey(name1))
                    {
                        uf.MakeSet(name1);
                    }
                    if (!uf.parents.ContainsKey(name2))
                    {
                        uf.MakeSet(name2);
                    }
                    uf.Union(name1, name2);
                    Console.WriteLine(uf.GetSize(name1));


                }
            }
        }
    }
}