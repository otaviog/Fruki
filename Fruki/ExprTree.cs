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
    public class EvalContext
    {
        private SAN san;
        private StatesSet currStateSet;
        private State state;        

        public SAN CurrSAN
        {
            get { return san; }
        }

        public StatesSet CurrStatesSet
        {
            get { return currStateSet; }
        }

        public State CurrState
        {
            get { return state; }
        }

        public EvalContext(SAN san, StatesSet stateSet, State state)
        {
            this.san = san;
            this.currStateSet = stateSet;
            this.state = state;
        }

    }

    public interface Expr
    {
        float Eval(EvalContext ctx);
    }

    public class AritExpr : Expr
    {
        private Expr left, right;
        private char op;

        public AritExpr(char op, Expr left, Expr right)
        {
            this.left = left;
            this.right = right;
            this.op = op;
        }

        public float Eval(EvalContext ctx)
        {
            float val,
                leftval = left.Eval(ctx),
                rightval = right.Eval(ctx);
                
            switch (op)
            {
                case '+':
                    val = leftval + rightval;
                    break;
                case '-':
                    val = leftval - rightval;
                    break;
                case '*':
                    val = leftval * rightval;
                    break;
                case '/':
                    val = leftval / rightval;
                    break;
                case 'b':
                default:
                    val = rightval;
                    break;
            }

            return val;
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("(" + op + " ");            
            strBuilder.Append(left.ToString());
            strBuilder.Append(" ");
            strBuilder.Append(right.ToString());
            strBuilder.Append(")");
            return strBuilder.ToString();
        }
    }

    public class LogicExpr : Expr
    {
        public enum Operators
        {
            AND, OR, XOR, EQ, GT, LT, EGT, ELT, NOTEQ, UNARY
        }

        private Expr left, right;
        private Operators op;
        private String optor;
        public LogicExpr(string optor, Expr left, Expr right)
        {
            this.left = left;
            this.right = right;
            this.optor = optor;

            if (optor == "<")
            {
                op = Operators.LT;
            }
            else if (optor == "<=")
            {
                op = Operators.ELT;
            }
            else if (optor == ">")
            {
                op = Operators.GT;
            }
            else if (optor == ">=")
            {
                op = Operators.EGT;
            }
            else if (optor == "=")
            {
                op = Operators.EQ;
            }
            else if (optor == "and")
            {
                op = Operators.AND;
            }
            else if (optor == "or")
            {
                op = Operators.OR;
            }
            else if (optor == "!>")
            {
                op = Operators.NOTEQ;
            }
            else
            {
                op = Operators.UNARY;
            }
        }

        public float Eval(EvalContext ctx)
        {
            bool bval = false;
            float leftval = left.Eval(ctx);
            float rightval = right.Eval(ctx);
            switch (op)
            {
                case Operators.AND:
                    bval = IsNotZero(leftval) && IsNotZero(rightval);
                    break;
                case Operators.OR:
                    bval = IsNotZero(leftval) || IsNotZero(rightval);
                    break;
                case Operators.XOR:
                    bval = bval ^ IsNotZero(rightval);
                    break;
                case Operators.EQ:
                    bval = Math.Abs(leftval - rightval) < float.Epsilon;
                    break;
                case Operators.GT:
                    bval = leftval > rightval;
                    break;
                case Operators.LT:
                    bval = leftval < rightval;
                    break;
                case Operators.EGT:
                    bval = leftval >= rightval;
                    break;
                case Operators.ELT:
                    bval = leftval <= rightval;
                    break;
                case Operators.NOTEQ:
                    bval = Math.Abs(leftval - rightval) >= float.Epsilon;
                    break;
                case Operators.UNARY:
                    bval = rightval > 0.0f ? true : false;
                    break;
            }

            return bval ? 1.0f : 0.0f;
        }

        public static bool IsZero(float val)
        {
            return !IsNotZero(val);
        }

        public static bool IsNotZero(float val)
        {
            return Math.Abs(val) > float.Epsilon;
        }

        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();
            strb.Append("(" + optor + " ");            
            strb.Append(left.ToString());
            strb.Append(" ");
            strb.Append(right.ToString());
            strb.Append(')');

            return strb.ToString();
        }
    };

    public class NodeStateExpr : Expr
    {
        private string autonomusName;

        public NodeStateExpr(string autonomusName)
        {
            this.autonomusName = autonomusName;
        }

        public float Eval(EvalContext ctx)
        {
            StatesSet stSet = ctx.CurrStatesSet;
            State state = ctx.CurrState;
            int autonomusIdx = stSet.GetAutonomusStateIndice(autonomusName);

            Autonomus autonomus = ctx.CurrSAN.AutonomusAt(autonomusIdx);

            return (float) autonomus.NodeAt(state[stSet.GetAutonomusStateIndice(autonomusName)]);
        }

        public override string ToString()
        {
            return autonomusName;
        }
    }

    public class ValueExpr : Expr
    {
        private float value;

        public ValueExpr(float value)
        {
            this.value = value;
        }

        public float Eval(EvalContext ctx)
        {
            return value;
        }

        public override string ToString()
        {
            return "" + value;
        }
    }
}
