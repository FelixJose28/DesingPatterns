using System.Collections;
using System.Collections.Generic;

namespace Iterator2
{
    internal class MyEnumerableCollection : IEnumerable
    {
        List<string> _collection = new List<string>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> GetItems()
        {
            return _collection;
        }

        public void AddItem(string item)
        {
            this._collection.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this, _direction);
        }
    }
}
