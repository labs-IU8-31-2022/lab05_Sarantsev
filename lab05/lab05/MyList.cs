using System;
using System.Xml.Linq;

namespace lab05
{
    public class MyList<T>
    {

        private T[] data_;
        private int size_;

        public MyList()
        {
            data_ = Array.Empty<T>();
        }

        public MyList(int capacity)
        {
            if (capacity == 0)
            {
                data_ = Array.Empty<T>();
            } else
            {
                data_ = new T[capacity];
            }
            if (capacity < 0)
            {
                throw new Exception("Capacity cant be less then 0");
            }
        }

        public MyList(params T[] data)
        {
            if (data is ICollection<T> copy)
            {
                var count = copy.Count;

                if (count != 0)
                {
                    data_ = new T[count];
                    Array.Copy(data, data_, count);
                    size_ = count;
                }
                else
                {
                    data_ = Array.Empty<T>();
                }
            }
        }

        public int Capacity
        {
            get => data_.Length;
            set
            {
                if (value < size_)
                {
                    throw new Exception("New capacity is less than list size");
                }

                if (value != data_.Length)
                {
                    if (value > 0)
                    {
                        T[] new_data = new T[value];
                        if (size_ > 0)
                        {
                            Array.Copy(data_, new_data, size_);
                        }

                        data_ = new_data;
                    }
                    else
                    {
                        data_ = Array.Empty<T>();
                    }
                }
            }
        }

        public void Add(T value)
        {
            if (size_ < data_.Length)
            {
                data_[size_] = value;
                ++size_;
            }
            else
            {
                if (data_.Length == 0)
                {
                    Capacity = 4;
                } else
                {
                    Capacity = 2 * data_.Length;
                }
                data_[size_] = value;
                ++size_;
            }
        }


        public int Count => size_;

        public void Clear()
        {
            if (size_ > 0)
            {
                Array.Clear(data_, 0, (int)size_);
                size_ = 0;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < Count; ++i)
            {
                yield return data_[i];
            }
        }

        public T this[int index]
        {
            get => data_[index];
            set => data_[index] = value;
        }
    }
}

