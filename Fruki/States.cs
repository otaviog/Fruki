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
    public class StatesSet : System.Collections.IEnumerable
    {
        private int[] cellMaxCount;
        private int stateCount;
        private LinkedList<Autonomus> autList;
        private Dictionary<string, int> autonomus2state = new Dictionary<string,int>();

        public StatesSet(LinkedList<Autonomus> autList)
        {
            this.autList = autList;
            cellMaxCount = new int[autList.Count];

            stateCount = 1;
            int count = 0;
            foreach (Autonomus aut in autList)
            {
                cellMaxCount[count] = aut.NodeCount;
                autonomus2state[aut.Name] = count;
                stateCount *= aut.NodeCount;
                ++count;
            }
        }

        public int AutonomusCount
        {
            get { return cellMaxCount.Length; }
        }

        public int MaxStates
        {
            get { return stateCount; }
        }

        public int MaxCount(int i)
        {
            return cellMaxCount[i];
        }

        public State Zero()
        {
            return new State(this);
        }

        public string StateToString(State state)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < AutonomusCount; i++)
            {
                builder.Append(autList.ElementAt(i).NodeAt(state[i]));
            }
            return builder.ToString();
        }

        public int GetAutonomusStateIndice(string autonomusName)
        {
            return autonomus2state[autonomusName];
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            State state = Zero();
            for (int i = 0; i < MaxStates; i++, state.Increment())
            {
                yield return state;
            }
        }
    }

    public class State
    {
        private int[] cells;
        private StatesSet states;        

        public int this[int index]
        {
            get { return cells[index]; }
            set { cells[index] = value; }
        }

        public State(StatesSet states)
        {
            this.states = states;
            cells = new int[states.AutonomusCount];            
        }

        public State(State other)
        {
            this.states = other.states;
            this.cells = (int[]) other.cells.Clone();
        }

        public void Increment()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i] < states.MaxCount(i) - 1)
                {
                    cells[i] += 1;
                    break;
                }
                else
                {
                    cells[i] = 0;
                }
            }
        }
    }
}
