using System;

namespace Assignmt2
{
    class Chessboard
    {
        static void Main(String[] args)
        {
            /**
             * For this assignment, you will create the pattern of a chess board that is 8 x 8.  Use X and O to represent the squares.

                Create the appropriate nested looping structure to output the characters in an 8 x 8 grid on the screen using Console.Write() or Console.WriteLine() as appropriate.
                Include a decision structure to ensure that alternate rows start with opposite characters as a real chess board alternates the colors among rows.
                This is what your output should look like.

                XOXOXOXO
                OXOXOXOX
                XOXOXOXO
                OXOXOXOX
                XOXOXOXO
                OXOXOXOX
                XOXOXOXO
                OXOXOXOX

                Grading Criteria:

                Used a nested loop
                Used a decision structure to flip row output
                Output is correct per above image
             * */
            
            int BoardDimention = 8;
            
            // implement the algorithm to display an 8x8 chessboard

            // this loop deals with rows one by one
            for(int i = 0; i < BoardDimention; i++)
            {
                // this loop deals with each character of the chessboard
                for(int j = 0; j < BoardDimention; j++)
                {
                    if(i % 2 == 0)
                    {
                        if(j % 2 != 0)
                        {
                            Console.Write('X');
                        }
                        else
                        {
                            Console.Write('O');
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('O');
                        }
                        else
                        {
                            Console.Write('X');
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}