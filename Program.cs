// Comments that have an initial number are the ones corresponding to an AI question, suggested improvement and a solution.
using System;

namespace Project_Chessboard
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // 3 My Chessboard() method was printing ??? instead of the desired squares so Copilot suggested me to enable UTF-8 encoding and it worked.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Reading chessboard size
            int size = ReadSize();
            Console.WriteLine($"Selected size: {size}");

            // Printing Chessboard
            var board = new RenderBoard();
            board.Chessboard(size);
        }
    }
}
