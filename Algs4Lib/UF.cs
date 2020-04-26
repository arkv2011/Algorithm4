using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm4
{
    public class UF
    {
        int[] id;
        int[] sz;
        public int Count { get; set; }

        public UF(int N)
        {
            id = new int[N];
            sz = new int[N];
            Count = N;
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                sz[i] = 1;
            }
        }

        public bool connected(int p, int q)
        {
            //return id[p] == id[q];
            return quickFind(p) == quickFind(q);
        }

        public int find(int p)
        {
            return id[p];
        }

        public int quickFind(int p)
        {
            while (p != id[p]) p = id[p];
            return p;
        }

        public void union(int p, int q)
        {
            if (connected(p, q)) return;
            int pID = find(p);
            int qID = find(q);
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == qID)
                    id[i] = pID;
            }
            Count--;
        }

        public void quickUnion(int p, int q)
        {
            int pRoot = quickFind(p);
            int qRoot = quickFind(q);

            if (connected(p, q)) return;
            id[pRoot] = qRoot;
            Count--;
        }

        public void weightedQuickUnion(int p, int q)
        {
            int pRoot = quickFind(p);
            int qRoot = quickFind(q);

            if (pRoot == qRoot) return;
            if (sz[pRoot] < sz[qRoot])
            {
                id[pRoot] = qRoot;
                sz[qRoot] += sz[pRoot];
            }
            else
            {
                id[qRoot] = pRoot;
                sz[pRoot] += sz[qRoot];
            }
            Count--;
        }
    }
}
