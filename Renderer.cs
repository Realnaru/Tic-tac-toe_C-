using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace againTic_Tac_Toe
{
    class Renderer
    {
        public void Render(Board board)
        {
            char[,] symbols = new char[3, 3];//array of char 3x3
            for (int row = 0; row < 3; row++)//for row from 0 to 2
                for (int column = 0; column < 3; column++)//for column from 0 to 2
                    symbols[row, column] = SymbolFor(board.getState(new Position(row, column)));

            //fill our array of char with symbols from board(convert state.X to 'X', state.O to 'O'
            //state.Undecided to ' ' 
            
            /*
              public State getState(Position position)
        {
            return state[position.row, position.column];
        }
             */

            //draws our "board" and places X,Y or ' ' on it
            Console.WriteLine($" {symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]}");
        }

            private char SymbolFor(State state)//convert state.something into char
            {
                switch (state)
                {
                    case State.O: return 'O';
                    case State.X: return 'X';
                    default: return ' ';
                }

            }

            public void RenderResults(State winner)//prints symbol for winner(X, Y, or Draw)
            {
                switch (winner)
                {
                    case State.O:
                    case State.X:
                        Console.WriteLine(SymbolFor(winner) + " wins!");
                        break;
                    case State.Undecided:
                        Console.WriteLine("Draw!");
                        break;

                }
            }


        
    }
}
