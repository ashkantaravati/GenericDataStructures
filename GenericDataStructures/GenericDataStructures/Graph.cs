using System.Collections.Generic;
using System.Linq;

namespace CACTB.GenericDataStructures
{
    public class Graph<T>
    {
        public class Vertex
        {
            public int Id;
            public T Data;

           
        }
        public class Edge
        {
            public Edge(Vertex src,Vertex dest)
            {
                Source = src;
                Destination = dest;
            }
            public Vertex Source;
            public Vertex Destination;
        }
        public List<Vertex> Vertices;
        public List<Edge> Edges;

        public void AddVertex(Vertex v)
        {
            Vertices.Add(v);
        }
        public void RemoveVertex(int vertexId)
        {
            
            Vertices.Remove((from x in Vertices
                             where (x.Id == vertexId)
                             select x).FirstOrDefault());
        }
        public void Relate(int sourceVertexId,int destinationVertexId)
        {
            var src = (from x in Vertices
                      where (x.Id == sourceVertexId)
                      select x).FirstOrDefault();
            var dest = (from x in Vertices
                       where (x.Id == destinationVertexId)
                       select x).FirstOrDefault();
            var relation = new Edge(src, dest);
            Edges.Add(relation);
        }
    }
   
}
