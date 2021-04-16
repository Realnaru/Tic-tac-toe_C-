using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace againTic_Tac_Toe
{
    public class Player
    {
        public Position GetPosition(Board board)
        {
            int position = Convert.ToInt32(Console.ReadLine());// take position form user(from 1 to 9)
            Position desiredCoordinate = PositionNumber(position);// coordinate = switch of 1 to 9
            return desiredCoordinate;//get coordinate (new position(row,column) from switch
        }
        /*
         * public class Position
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

        private Position PositionNumber(int position)//switch users input and create and return position 
                                                     //on the board new position(row, column)
                                                     //if not from 1 to 9, then return null
            {
                switch (position)
                {
                    case 1: return new Position(2, 0);
                    case 2: return new Position(2, 1);
                    case 3: return new Position(2, 2);
                    case 4: return new Position(1, 0);
                    case 5: return new Position(1, 1);
                    case 6: return new Position(1, 2);
                    case 7: return new Position(0, 0);
                    case 8: return new Position(0, 1);
                    case 9: return new Position(0, 2);
                    default: return null;


                }
       
        }
    }
}
