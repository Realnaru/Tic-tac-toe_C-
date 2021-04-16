using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace againTic_Tac_Toe
{
   public class WinChecker
    {
        public State Check(Board board)
        {
            if (CheckForWin(board, State.X)) return State.X;
            if (CheckForWin(board, State.O)) return State.O;
            return State.Undecided;
        }

        private bool CheckForWin(Board board, State player)//check situation on the board to find a winner
        //check for same symbols in every line(0,0 0,1, 0,2 then 1,0 1,1 1,2 and so on)
        {
            for (int row = 0; row < 3; row++)
                if (AreAll(board, new Position[] { new Position(row,0),
                                                   new Position(row,1),
                                                   new Position(row,2)}, player))
                    return true;
            for (int column = 0; column < 3; column++)
                if (AreAll(board, new Position[] { new Position(0,column),
                                                   new Position(1,column),
                                                   new Position(2,column)}, player))
                    return true;

            if (AreAll(board, new Position[] { new Position(0,0),
                                                   new Position(1,1),
                                                   new Position(2,2)}, player))

                if (AreAll(board, new Position[] { new Position(2,0),
                                                   new Position(1,1),
                                                   new Position(0,2)}, player))
                    return true;
            return false;
        }

        private bool AreAll(Board board, Position[] positions, State state)//check for same states
        {
            foreach (Position position in positions)
                if (board.getState(position) != state) return false;
            return true;
        }

            public bool isDraw(Board board)// check if our board is filled
            {
                for (int row = 0; row < 3; row++)//go through rows
                    for (int column = 0; column < 3; column++)//go through columns
                    // if there are any position that is ' 'then false(undrawn)
                        if (board.getState(new Position(row, column)) == State.Undecided) return false;
                return true;//if there is not then true
            }

            }


        }
    

