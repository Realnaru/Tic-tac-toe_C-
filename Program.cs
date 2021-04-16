using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace againTic_Tac_Toe
{
    public enum State { Undecided, X, O}//enumeration that consists of three cases of state
                                        //X or Y or Undecidede (void) 
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            WinChecker winChecker = new WinChecker();
            Renderer renderer = new Renderer();
            Player player1 = new Player();
            Player player2 = new Player();

            while (!winChecker.isDraw(board) && winChecker.Check(board) == State.Undecided)
            {
                renderer.Render(board);
                Position nextMove;

                if (board.NextTurn == State.X)
                    nextMove = player1.GetPosition(board);
                else
                    nextMove = player2.GetPosition(board);
                if (!board.setState(nextMove, board.NextTurn))
                    Console.WriteLine("That is not legal move");
            }

            renderer.Render(board);
            renderer.RenderResults(winChecker.Check(board));
            Console.ReadKey();

        }
    }
}
