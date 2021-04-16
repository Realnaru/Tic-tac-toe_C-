using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace againTic_Tac_Toe
{
    public class Board
    {
        private State[,] state;// array of state(X, Y, Undecided)
            public State NextTurn { get; private set; }//property thats defines whose turn is next
        public Board()
        {
            state = new State[3, 3];//array 3x3 of state
            NextTurn = State.X;//first turn is X
        }

        public State getState(Position position)
        {
            return state[position.row, position.column];
        }
        /*
          public class Position
    {
        public int row { get; }//property row
        public int column { get; }//property column
        //this class is for keeping position on our board
        public Position (int row, int Column)//constructor of position class
        {
            this.row = row;
            this.column = Column;
        }
    }
         */

        public bool setState(Position position, State newState)
        {
            if (newState != NextTurn) return false;//if not next turn = false
            if (state[position.row, position.column] != State.Undecided) return false;//if state[r,c] != '' 
            //then = false
            state[position.row, position.column] = newState;// else = newState
            SwitchNextTurn();// next turn
            return true;//if next if !=' ' = true
        }

        private void SwitchNextTurn()//define next turn
        {
            if (NextTurn == State.X) NextTurn = State.O;// if not X then O
            else NextTurn = State.X;//if not then X
        }
    }
}
