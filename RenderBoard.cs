using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. I asked Copilot how I can make a RenderBoard class more flexible in the long-term, meaning that I can later use it to e.g. storing board state.
// The recommendation was that I would use public void Chessboard(int n) so that I can instantiate class when needed. 
// This seems like good advice. It ensures that I will be able to instantiate the class when needed and print out what the board looks like after a player made a turn.
// Copilot also told me that in order to associate a square to a piece I would need to create a Square class and respectively a Piece class. This suggestion will be a future project.
// This is the solution:

namespace Project_Chessboard
{
    public class RenderBoard
    {
        public void Chessboard(int n)
        {
            // Going through each row and column to determine whether square is black or white.
            for(int row = 0; row < n; row++)
            {
                for(int column = 0; column < n; column++)
                {
                    switch(row%2)
                    {
                        case 1:
                            if (column % 2 == 0)
                            {
                                // White square
                                Console.Write("◼︎"); // ◼︎
                            }
                            else
                            {
                                // Black square
                                Console.Write("◻︎"); // ◻︎
                            }
                            break;
                        default:
                            if (column % 2 == 1)
                            {
                                // White square
                                Console.Write("◼︎"); // ◼︎
                            }
                            else
                            {
                                // Black square
                                Console.Write("◻︎"); // ◻︎
                            }
                            break;


                    }
                }
                //New row
                Console.WriteLine();
            }
        }
    }
}
