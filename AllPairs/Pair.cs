using System;

namespace AllPairs
{
    internal class Pair
    {
        private int _indexA;
        private int _indexB;
        private string[] _values;
        private int _lastIndex;

        public Pair(string[] values)
        {
            _values = values;
            _indexA = 0;
            _indexB = 1;
            _lastIndex = _values.Length - 1;
        }

        public void Show()
        {
            Console.WriteLine($"{_values[_indexA]} {_values[_indexB]}");
        }

        public bool HasNext()
        {
            return _indexA <= _lastIndex && _indexB <= _lastIndex;
        }

        public void Next()
        {
            do
            {
                _indexB++;
                if (_indexB > _lastIndex)
                {
                    _indexA++;
                    _indexB = 0;
                }
            } while (_indexB == _indexA);
        }
    }
}
