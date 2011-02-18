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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fruki
{
    class PendingEdge
    {
        private int autonomusIdx;
        private int destNodeIdx;

        public int AutonomusIdx
        {
            get { return autonomusIdx; }
        }

        public int DestNodeIdx
        {
            get { return destNodeIdx; }
        }

        public PendingEdge(int autonomusIdx, int destNodeIdx)
        {
            this.autonomusIdx = autonomusIdx;
            this.destNodeIdx = destNodeIdx;
        }

    }

    public class SAN
    {
        private LinkedList<Autonomus> autonomus = new LinkedList<Autonomus>();
        private Dictionary<string, Event> events = new Dictionary<string, Event>();
        
        public SAN()
        {
        }

        public void AddAutonomus(Autonomus an)
        {
            autonomus.AddLast(an);
        }

        public void AddEvent(string name, Event.EventType evtTp, Expr expr)
        {
            events[name] = new Event(name, evtTp, expr);
        }        

        public void AddEvent(Event ev)
        {
            events[ev.Name] = ev;
        }

        public Autonomus AutonomusAt(int idx)
        {
            return autonomus.ElementAt(idx);
        }

        public Tuple<int, int> GenerateDotVis(System.IO.TextWriter writer)
        {
            int transitionCount = 0;
            writer.WriteLine("digraph Markov {");

            StatesSet stateset = new StatesSet(autonomus);            
            foreach (State state in stateset)
            {
                string sMarkovCurrState = stateset.StateToString(state);

                Dictionary<Event, LinkedList<PendingEdge>> synPendingEvents =
                    new Dictionary<Event, LinkedList<PendingEdge>>();

                for (int cntAut = 0; cntAut < stateset.AutonomusCount; cntAut++)
                {
                    Autonomus aut = autonomus.ElementAt(cntAut);
                    int nodeName = aut.NodeAt(state[cntAut]);
                    LinkedList<Edge> edges = aut.GetEdges(nodeName);

                    foreach (Edge edge in edges)
                    {                        
                        Event ev = null;                       
                        events.TryGetValue(edge.Event, out ev);

                        if (ev != null)
                        {                                                       
                            int idxToNodeName = aut.NodeNameIndex(edge.DestName);
                            float tax = edge.Tax * ev.Eval(this, stateset, state);
                            if (tax > 0.0f)
                            {
                                if (ev.Type == Event.EventType.LOC)
                                {
                                    State markovToState = new State(state);
                                    markovToState[cntAut] = idxToNodeName;                             

                                    PrintRelation(writer, sMarkovCurrState, stateset.StateToString(markovToState), tax);
                                    ++transitionCount;
                                }
                                else
                                {
                                    LinkedList<PendingEdge> penEvents;
                                    PendingEdge pendingEvent = new PendingEdge(cntAut, idxToNodeName);

                                    if (synPendingEvents.TryGetValue(ev, out penEvents))
                                    {
                                        penEvents.AddLast(pendingEvent);
                                    }
                                    else
                                    {
                                        penEvents = new LinkedList<PendingEdge>();
                                        penEvents.AddLast(pendingEvent);
                                        synPendingEvents[ev] = penEvents;
                                    }
                                }
                            }
                        } //  if (ev != null)
                        else
                        {
                            System.Console.WriteLine("Warnning: edge with direction " + edge.DestName + " has no event " + edge.Event);
                        }

                    } // foreach (Edge edge in edges)
                } //  for (int j = 0; j < stateset.Count; j++)

                                
                foreach (KeyValuePair<Event, LinkedList<PendingEdge>> pending in synPendingEvents)
                {
                    Event ev = pending.Key;
                    LinkedList<PendingEdge> penEdges = pending.Value;

                    if ( penEdges.Count > 1 ) 
                    {
                        State toMarkovState = new State(state);
                        foreach (PendingEdge pedge in penEdges)
                        {
                            toMarkovState[pedge.AutonomusIdx] = pedge.DestNodeIdx;
                        }

                        float tax = ev.Eval(this, stateset, state);
                        if (tax > 0.0f)
                        {
                            PrintRelation(writer, sMarkovCurrState, stateset.StateToString(toMarkovState), tax);
                            ++transitionCount;
                        }
                    }
                }
            }

            writer.WriteLine("}");

            return new Tuple<int, int>(stateset.MaxStates, transitionCount);
        }

        private static void PrintRelation(System.IO.TextWriter writer, string sMarkovCurrState, string sMarkovToState, float tax)
        {            
            if (tax > 0.0f)
            {                                
                writer.WriteLine(sMarkovCurrState + " -> " + sMarkovToState
                 + " [label=\"" + tax + "\"];"
                 );
            }
        }        
    }

    public class SANLoader
    {
        public SAN ParseFile(string filename)
        {
            SAN san = new SAN();
            SANLexer lexer = new SANLexer(new Antlr.Runtime.ANTLRFileStream(filename));
            Antlr.Runtime.CommonTokenStream tokens = new Antlr.Runtime.CommonTokenStream(lexer);

            SANParser parser = new SANParser(tokens);            
            parser.start(san);
            
            return san;            
        }

    };
}
