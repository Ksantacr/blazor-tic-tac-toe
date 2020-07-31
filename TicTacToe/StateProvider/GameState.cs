using System;
using System.Collections.Generic;

namespace TicTacToe.StateProvider
{
    public class GameState
    {
        public List<string[]> history;
        public bool xIsNext { get; set; }
        public event Action OnChange;
        public GameState()
        {
            history = new List<string[]>();
            string[] array = new string[9];
            history.Add(array);
            xIsNext = true;
        }
        public void notifyChanges()
        {
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
