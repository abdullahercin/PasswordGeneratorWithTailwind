namespace PasswordGeneratorWithTailwind.Memento
{
    public class PasswordCaretaker
    {
        private readonly List<string> _mementos = new();
        private int _currentIndex = -1;
        private const int MaxHistory = 20;

        public async Task BackupAsync(string password)
        {
            await Task.Run(() =>
            {
                if (_currentIndex < _mementos.Count - 1)
                {
                    _mementos.RemoveRange(_currentIndex + 1, _mementos.Count - _currentIndex - 1);
                }

                _mementos.Add(password);
                _currentIndex = _mementos.Count - 1;

                if (_mementos.Count > MaxHistory)
                {
                    _mementos.RemoveAt(0);
                    _currentIndex--;
                }
            });
        }

        public bool CanUndo() => _currentIndex > 0;
        public bool CanRedo() => _currentIndex < _mementos.Count - 1;

        public async Task<string> UndoAsync()
        {
            return await Task.Run(() =>
            {
                if (!CanUndo()) return string.Empty;
                _currentIndex--;
                return _mementos[_currentIndex];
            });
        }

        public async Task<string> RedoAsync()
        {
            return await Task.Run(() =>
            {
                if (!CanRedo()) return string.Empty;
                _currentIndex++;
                return _mementos[_currentIndex];
            });
        }
    }
}