using System;

namespace TicTacToe.Services
{
    public class GameService
    {
        // https://es.reactjs.org/tutorial/tutorial.html
        public string calculateWinner(string[] squares)
        {
            // 8x3 dimensional array
            int[,] lines = new int[8, 3]
            {
                { 0, 1, 2},
                { 3, 4, 5},
                { 6, 7, 8},
                { 0, 3, 6},
                { 1, 4, 7},
                { 2, 5, 8},
                { 0, 4, 8},
                { 2, 4, 6},
                };
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    var a = lines[i, 0];
                    var b = lines[i, 1];
                    var c = lines[i, 2];

                    if (!string.IsNullOrEmpty(squares[a]))
                    {
                        if (squares[a] == squares[b] && squares[a] == squares[c])
                        {
                            return squares[a];
                        }
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
            return string.Empty;
        }


    }
}
