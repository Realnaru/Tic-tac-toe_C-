using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace againTic_Tac_Toe
{
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
}
