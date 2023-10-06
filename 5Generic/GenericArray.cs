using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Generic
{
    // 定义一个 GenericArray<E>，操作一个未指定的数据类型 E
    internal class GenericArray<E>   
    {
        private E[] data;    
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

        public GenericArray(int capacity)
        {
            data = new E[capacity];
            N = 0;
        }

        public GenericArray() : this(10) { }

        // 打印  ToString()
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

        // 添加
        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            if (N == data.Length)
                throw new ArgumentException("数组已满");

            for (int i = N - 1; i >= index; i--)  
            {
                data[i + 1] = data[i];
            }

            data[index] = e;     
            N++;                 
        }

        public void AddLast(E e)
        {
            Add(N, e);
        }

        public void AddFirst(E e)
        {
            Add(0, e);
        }

        // 获取
        public E Get(int index)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            return data[index];
        }

        public E GetFirst()
        {
            return Get(0);
        }

        public E GetLast()
        {
            return Get(N - 1);
        }

        // 修改
        public void Set(int index, E newE)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            data[index] = newE;
        }

        // 包含
        public bool Contains(E e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))   // 两个引用类型的比较，是比较它们的内存地址，用 Equals
                    return true;
            }
            return false;
        }

        // 某个元素的 index
        public int IndexOf(E e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                    return i;
            }
            return -1;   // 小于 0 的 数值，都可以作为无效的 index
        }

        // 删除
        public E RemoveAt(int index)
        {
            // 索引检查
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            // 保存要删除的元素
            E del = data[index];

            // 删除逻辑
            for (int i = index + 1; i < N; i++)
            {
                data[i - 1] = data[i];
            }

            N--;

            // 回收 data[N]
            data[N] = default(E);

            return del;
        }

        public E RemoveFirst()
        {
            return RemoveAt(0); ;
        }

        public E RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        public void RemoveE(E e)
        {
            int index = IndexOf(e);
            if (index != -1)
            {
                RemoveAt(index);
            }
        }

        // 数组扩容
        private void ResetCapacity(int newCapacity)
        {
            E[] newData = new E[newCapacity];
            for (int i = 0; i < N; i++)
                newData[i] = data[i];

            data = newData;
        }
    }
}
