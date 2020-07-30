using System;

namespace TicTacToe.StateProvider
{
    public class GameState
    {
        public string[] squares = new string[9];
        public bool xIsNext { get; set; }
        public event Action OnChange;
        public GameState()
        {
            xIsNext = true;
            for (int i = 0; i < 9; i++)
            {
                squares[i] = string.Empty;
            }
        }
        public void notifyChanges()
        {
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
