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
    public class Event
    {
        public enum EventType
        {
            SYN, LOC
        };

        private string name;
        private EventType type;       
        private Expr exprTree;

        public string Name
        {
            get { return name; }
        }

        public EventType Type
        {
            get { return type; }
        }

        public Event(string name, EventType type, Expr exprTree)
        {
            this.name = name;
            this.type = type;            
            this.exprTree = exprTree;
        }

        public float Eval(SAN san, StatesSet stateSet, State state)
        {
            if (exprTree != null)
            {
                return exprTree.Eval(new EvalContext(san, stateSet, state));
            }
            else
            {
                return 1.0f;
            }
        
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool eq = false;

            if (obj is Event)
            {
                Event other = (Event)obj;
                eq = name == other.Name && type == other.type;
            }

            return eq;            
        }
    };    
}
