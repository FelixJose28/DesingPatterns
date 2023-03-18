using System.Collections;

namespace Iterator
{
    internal class MyEnumerator : IEnumerator
    {
        private int[] _elements;
        private int _position = -1;

        public MyEnumerator(int[] elements)
        {
            _elements = elements;
        }

        public object Current
        {
            get
            {
                return _elements[_position];
            }
        }

        public bool MoveNext()
        {
            _position++;
            if (_position < _elements.Length)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
