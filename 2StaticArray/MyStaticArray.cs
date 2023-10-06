using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StaticArray
{
    internal class MyStaticArray
    {
        private int[] data;    // 静态数组用于存储数据
        private int N;         // 记录动态数组实际存贮的元素数量

        // 只给用户访问的权限，所以只要 get 方法
        public int Capacity     // 数组长度
        {
            get { return data.Length; }
        }

        public int Count        // 动态数组实际存贮的元素数量
        {
            get { return N; }
        }

        public bool IsEmpty     // 判断动态数组是否为空，为空，返回 true
        {
            get { return N == 0; }
        }


        // 创建两个构造函数
        // 1）包含入口参数，容量可变
        public MyStaticArray(int capacity)
        {
            data = new int[capacity];
            N = 0;
        }

        // 2）不包含入口参数，容量固定为10
        /*
        public Array1()         // non-argument
        {
            data = new int[10];
            N = 0;
        }*/

        public MyStaticArray() : this(10) { } // 优雅的写法 this 


        // 添加元素 e，到指定位置 index
        // index 之后的所有元素，从最后一个元素 N-1 开始，逐个往后挪一位。
        public void Add(int index, int e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            if (N == data.Length)
                throw new ArgumentException("数组已满");

            for (int i = N - 1; i >= index; i--)  // 从 最后一个元素 N-1 开始往后挪一位，再将前一个数往后挪一位，直到 index
            {
                data[i + 1] = data[i];
            }

            data[index] = e;     //  将 e 添加到 index
            N++;                 //  因为数组多了一个元素，所以 N++
        }

        // 添加元素 e 到 数组的末尾
        public void AddLast(int e)
        {
            Add(N, e);
        }

        // 添加元素 e 到 数组的开头
        public void AddFirst(int e)
        {
            Add(0, e);
        }

        // ToString()，遍历元素数值，将其转变为 string，再拼接起来
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            // string 的拼接
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

        // 获取元素
        public int Get(int index)
        {
            // 合法索引： 0=<index<N   -->  不合法索引：index<0 || index>=N
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

        // 修改元素
        public void Set(int index, int newE)
        {
            // 索引检查
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            data[index] = newE;
        }

        // 包含
        public bool Contains(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] == e)
                    return true;
            }
            return false;
        }

        // 某个元素的 index
        public int IndexOf(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] == e)
                    return i;
            }
            return -1;   // 小于 0 的 数值，都可以作为无效的 index
        }

        // 删除
        public int RemoveAt(int index)
        {
            // 索引检查
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            // 保存要删除的元素
            int del = data[index];

            // 删除逻辑
            for (int i = index + 1; i < N; i++)
            {
                data[i - 1] = data[i];
            }

            N--;

            // 回收 data[N]
            data[N] = default(int);

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
