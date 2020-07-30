using System;

namespace TicTacToe.StateProvider
{
    public class GameState
    {
        public int turn { get; set; }
        public string[] squares = new string[9];
        public string symbol { get; set; }
        public event Action OnChange;
        public GameState()
        {
            symbol = "X";
            turn = 1;
        }
        public void nextTurn()
        {
            turn++;
            symbol = (turn % 2 == 0 ? "O" : "X");
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
