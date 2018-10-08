using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Dictionary<K, V>
    {
        private int _lenght;
        private int _count;
        private K[] _arrayKey;
        private V[] _arrayValue;

        public Dictionary()
        {
            _lenght = 10;
            _arrayKey = new K[_lenght];
            _arrayValue = new V[_lenght];
        }
       
        public int Count
        {
            get { return _count; }
        }

        public K[] Keys
        {
            get
            {
                K[] tmpArr = new K[_count];
                Array.Copy(_arrayKey,tmpArr, _count);
                return tmpArr;
            }
        }

        public V[] Values
        {
            get
            {
                V[] tmpArr = new V[_count];
                Array.Copy(_arrayValue, tmpArr, _count);
                return tmpArr;
            }
        }
        
        public V this[K key]
        {
            get
            {
                int numItea = FindIndexKey(key);
                if (numItea == -1)
                {
                    throw new InvalidOperationException("KeyNotExistException");
                }
                return _arrayValue[numItea];
            }

            set
            {
                int numItea = FindIndexKey(key);
                if (numItea > -1)
                {
                    _arrayValue[numItea] = value;
                }
                else
                {
                    SaveValue(key, value);
                }

            }

        }
        
        private void SaveValue(K key, V value)
        {
            if (_count < _lenght)
            {
                _arrayValue[_count] = value;
                _arrayKey[_count] = key;
                _count++;
            }
            else
            {
                int newSize = 0;
                if (_lenght * 10 / 100 < 10)
                {
                    newSize = _lenght + 10;
                }
                else
                {
                    newSize = _lenght * 110 / 100;
                }
                K[] newKeyArr = new K[newSize];
                V[] newValueArr = new V[newSize];
                _arrayKey.CopyTo(newKeyArr, 0);
                _arrayValue.CopyTo(newValueArr, 0);
                _lenght = newSize;
                _arrayKey = newKeyArr;
                _arrayValue = newValueArr;
                _arrayValue[_count] = value;
                _arrayKey[_count] = key;
                _count++;
            }

        }

        private int FindIndexKey(K key)
        {
            for (int i = 0; i < _count; i++)
            {
                if (key.Equals(_arrayKey[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        
        public void Add(K key, V value)
        {
            for (int i = 0; i < _count; i++)
            {
                if (key.Equals(_arrayKey[i]))
                {
                    throw new ArgumentException("Такой ключ уже существует");
                }
            }
            SaveValue(key, value);
        }

        public void Clear()
        {
            Array.Clear(_arrayKey, 0, _lenght);
            Array.Clear(_arrayValue, 0, _lenght);
            _count = 0;
        }

        public bool ContainsKey(K key)
        {
            for (int i = 0; i < _count; i++)
            {
                if (key.Equals(_arrayKey[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsValue(V value)
        {
            for (int i = 0; i < _count; i++)
            {
                if (value.Equals(_arrayValue[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove(K key)
        {
            int numItea = FindIndexKey(key);
            if (numItea > -1)
            {
                _arrayValue[numItea] = _arrayValue[_count - 1];
                _arrayKey[numItea] = _arrayKey[_count - 1];
                _count--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryGetValue(K key, out V value)
        {
            int numItea = FindIndexKey(key);
            if (numItea>-1)
            {
                value = _arrayValue[numItea];
                return true;
            }

            value = default(V);
            return false;
        }

    }
}
