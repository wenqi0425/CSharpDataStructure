using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    internal class MyDynamicArray
    {
        private int[] data;   
        private int N;        
        public int Capacity     
        {
            get { return data.Length; }
        }

        public int Count        
        {
            get { return N; }
        }

        public bool IsEmpty    
        {
            get { return N == 0; }
        }

        public MyDynamicArray(int capacity)
        {
            data = new int[capacity];
            N = 0;
        }

        public MyDynamicArray() : this(10) { }

        // 打印  ToString()，遍历元素数值，将其转变为 string，再拼接起来，否则打印不出具体的数值。
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            res.Append(string.Format("Array: count={0} capacity={1}\n", N, data.Length));
            res.Append('[');
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1)
                    res.Append(", ");
            }
            res.Append("]");
            return res.ToString();
        }

        // 数组扩容
        private void ResetCapacity(int newCapacity)
        {
            int[] newData = new int[newCapacity];
            for (int i = 0; i < N; i++)
                newData[i] = data[i];

            data = newData;
        }

        // CRUD，Add()要做扩容处理，Remove()要做容量判断，再决定要不要缩容，以避免空间浪费
        // 增加
        public void Add(int index, int e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            if (N == data.Length)
                ResetCapacity(2*data.Length);    // 容量不足时自动扩容为之前的两倍

            for (int i = N - 1; i >= index; i--)  
            {
                data[i + 1] = data[i];
            }

            data[index] = e;     
            N++;                 
        }

        public void AddLast(int e)
        {
            Add(N, e);
        }

        public void AddFirst(int e)
        {
            Add(0, e);
        }

        // 获取
        public int Get(int index)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            return data[index];
        }

        public int GetFirst()
        {
            return Get(0);
        }

        public int GetLast()
        {
            return Get(N - 1);
        }

        // 修改
        public void Set(int index, int newE)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            data[index] = newE;
        }

        // 搜索，包含
        public bool Contains(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] == e)
                    return true;
            }
            return false;
        }

        public int IndexOf(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] == e)
                    return i;
            }
            return -1;   
        }

        // 删除
        public int RemoveAt(int index)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            int del = data[index];

            for (int i = index + 1; i < N; i++)
            {
                data[i - 1] = data[i];
            }

            N--;

            data[N] = default(int);

            // 数组缩容，如果元素数量为数组长度的1/4，就缩容一半，避免空间浪费，因为实在用不了那么多。
            // 不选 1/2，因为当数组首次扩容，再删除这个数据，会触发缩容扩容操作各一次，如果频繁进行这一个数据的添加删除，会影响性能。
            if (N == data.Length / 4)      
                ResetCapacity(data.Length / 2);  

            return del;
        }

        public int RemoveFirst()
        {
            return RemoveAt(0); ;
        }

        public int RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        public void RemoveE(int e)
        {
            int index = IndexOf(e);
            if (index != -1)
            {
                RemoveAt(index);
            }
        }
    }
}
