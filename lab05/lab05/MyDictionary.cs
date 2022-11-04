using System;
using System.Collections;
using System.Drawing;
using System.Reflection;

namespace lab05
{
    public class MyDictionary<TKey, TValue>
    {
        private DictionaryEntry[] data_;
        private int size_;
        private int capacity_;
        public MyDictionary()
        { 
            size_ = 0;
            capacity_ = 0;
        }
        public MyDictionary(int input_capacity)
        {
            if (input_capacity < 0)
            {
                throw new Exception("Input capacity cant be negative");
            }
            data_ = new DictionaryEntry[input_capacity];
            size_ = 0;
            capacity_ = input_capacity;
        }
        public int Count => size_;
        public int Capacity => capacity_;

        public void genWithNewCapacity(int new_capacity)
        {
            DictionaryEntry[] new_data = new DictionaryEntry[new_capacity];
            for (int i = 0; i < size_; ++i)
            {
                new_data[i] = data_[i];
            }
            data_ = new_data;
            capacity_ = new_capacity;
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null) 
            {
                throw new ArgumentNullException("Key cant be 0");
            }
            if (size_ == capacity_)
            {
                genWithNewCapacity(capacity_ * 2 + 1);
            }
            ++size_;
            data_[Count - 1] = new DictionaryEntry(key, value);
        }
            
        public IEnumerator<DictionaryEntry> GetEnumerator()
        {
            for (var i = 0; i < size_; ++i)
            {
                yield return data_[i];
            }
        }

        public ICollection Keys
        {
            get
            {
                TKey[] keys = new TKey[size_];
                for (int i = 0; i < size_; ++i)
                {
                    keys[i] = (TKey)data_[i].Key;
                }
                return keys;
            }
        }

        public ICollection Values
        {
            get
            {
                TValue[] values = new TValue[size_];
                for (int i = 0; i < size_; ++i)
                {
                    if ((TValue)data_[i].Value == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        values[i] = (TValue)data_[i].Value;
                    }
                }
                return values;
            }
        }

        public bool keyFind(TKey key, int index)
        {
            for (index = 0; index < size_; ++index)
            {
                if (data_[index].Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public TValue this[TKey key, int index]
        {
            get
            {
                if (keyFind(key, index))
                {
                    return (TValue)data_[index].Value;
                } else
                {
                    return default(TValue);
                }
            }
            set
            {
                if (keyFind(key, index))
                {
                    data_[index].Value = value;
                } else
                {
                    Add(key, value);
                }
            }
        }

        
    }
}

