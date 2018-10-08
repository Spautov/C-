using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class SmartArray<T>
    {
        private T[] _array;
        private int _begin;
        private int _end;

        public int Begin
        {
            get
            {
                return _begin;
            }

            set
            {
                if (_begin <= _end)
                {
                    _begin = value;
                    if ((_end - _begin) > _array.Length)
                    {
                        CreateNewLength();
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Индекс первого элемента не может быть больше индекса последнего элемента");
                }
            }
        }


        public int End
        {
            get
            {
                return _end;
            }

            set
            {
                if (value >= _begin)
                {
                    _end = value;
                    if ((_end - _begin) > _array.Length)
                    {
                        CreateNewLength();
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Индекс последнего элемента не может быть меньше индекса начального элемента");
                }
            }
        }

        public int Length
        {
            get { return _end - _begin; }
        }

        private void CreateNewLength()
        {
            T[] tmpArr = new T[_end - _begin];
            _array.CopyTo(tmpArr, 0);
            _array = tmpArr;
        }

        public SmartArray()
        {
            _array = new T[0];
        }

        private void CheckRange(int i)
        {
            if (i == _end && _end == _begin)
            {
                throw new IndexOutOfRangeException("Массив имеет нулевую длинну");
            }
            if (i < _begin || i >= _end)
            {
                throw new IndexOutOfRangeException("Выход за пределы массива");
            }
        }
        public T this[int i]
        {
            get
            {
                CheckRange(i);
                return _array[i - _begin];
            }
            set
            {
                CheckRange(i);
                _array[i - _begin] = value;
            }
        }
    }
}
