/**    
 *    Fruk, transform a SAN to Graphviz Dot Language represention of it corresponding
 *    Markov Chain.
 *    Copyright (C) 2010  <Otávio Basso Gomes>
 *
 *    This program is free software: you can redistribute it and/or modify
 *    it under the terms of the GNU General Public License as published by
 *    the Free Software Foundation, either version 3 of the License, or
 *    (at your option) any later version.
 *
 *    This program is distributed in the hope that it will be useful,
 *    but WITHOUT ANY WARRANTY; without even the implied warranty of
 *    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *    GNU General Public License for more details.
 *
 *    You should have received a copy of the GNU General Public License
 *    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fruki
{
    public class Edge
    {
        private int toName;
        private string eventName;
        private float ratio;

        public int DestName
        {
            get { return toName; }
        }

        public string Event
        {
            get { return eventName; }
        }

        public float Tax
        {
            get { return ratio; }
        }

        public Edge(string eventName, int toName, float ratio)
        {
            this.toName = toName;
            this.eventName = eventName;
            this.ratio = ratio;
        }
    }

    public class Autonomus
    {        
        private ArrayList nodes = new ArrayList();
        private Dictionary<int, int> nodeIndiceLookup = new Dictionary<int, int>();
        private Dictionary<int, LinkedList<Edge>> edgeMap = new Dictionary<int, LinkedList<Edge>>();
        private string name;

        public int NodeCount
        {
            get { return nodes.Count; }
        }

        public string Name
        {
            get { return name; }
        }

        public Autonomus(string name)
        {
            this.name = name;
        }

        public void AddNode(int name)
        {
            if (!nodeIndiceLookup.ContainsKey(name))
            {
                nodes.Add(name);
                nodeIndiceLookup[name] = nodes.Count - 1;
                edgeMap[name] = new LinkedList<Edge>();
            }
            
        }

        public void AddEdge(string eventName, int fromNode, int toNode, float ratio)
        {
            AddNode(fromNode);
            AddNode(toNode);
            
            edgeMap[fromNode].AddLast(new Edge(eventName, toNode, ratio));                       
        }

        public int NodeAt(int i)
        {
            return (int) nodes[i];
        }

        public LinkedList<Edge> GetEdges(int node)
        {
            return edgeMap[node];
        }        

        public int NodeNameIndex(int p)
        {
            return nodeIndiceLookup[p];
        }
    }
}
