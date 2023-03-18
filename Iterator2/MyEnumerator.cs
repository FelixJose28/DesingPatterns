using System.Collections;

namespace Iterator2
{
    internal class MyEnumerator : IEnumerator
    {

        private MyEnumerableCollection _collection;

        private int _position = -1;

        private bool _reverse = false;

        public MyEnumerator(MyEnumerableCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.GetItems().Count;
            }
        }

        public object Current
        {
            get
            {
                return this._collection.GetItems()[_position];
            }
        }

        public bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.GetItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            this._position = this._reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }
}
