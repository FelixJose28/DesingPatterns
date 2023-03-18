using System.Collections;

namespace Iterator
{
    internal class MyEnumerableCollection : IEnumerable
    {
        private int[] elements = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(elements);
        }
    }
}
