using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7TimeComplexity
{
    internal class TimeComplexityAnalysisForDynamicArray
    {
        /*  动态数组 的 时间复杂度 分析

        1) 添加 Add

        public void Add(int index, int e)
        {
            if (index < 0 || index > N)     // AddLast 需要执行 语句 1， AddFirst 需要执行 语句 1
                throw new ArgumentException("数组索引越界");

            if (N == data.Length)           // AddLast 需要执行 语句 2， AddFirst 需要执行 语句 2 
                ResetCapacity(2*data.Length);    // 容量不足时自动扩容为之前的两倍

            for (int i = N - 1; i >= index; i--)   // AddFirst 需要执行 语句3 n 次
            {
                data[i + 1] = data[i];
            }

            data[index] = e;     // AddLast 需要执行 语句 3， AddFirst 需要执行 语句 4 
            N++;                 // AddLast 需要执行 语句 4， AddFirst 需要执行 语句 5     
        }

        public void AddLast(int e)    // AddLast() 需要执行 语句 4条 --> Time = 4 条语句的执行时间
        {                             // O(1)  时间复杂度 为 常数级别，即：通过固定的操作次数，就可以完成任务，
            Add(N, e);
        }

        public void AddFirst(E e)     // AddFirst 需要执行 语句 4+n 条  --> Time = (4+n) 条语句的执行时间  
        {                             // O(n)  时间复杂度 为 线性级别，即：当 n 趋近于 无穷时，常数 4 对于时间的影响非常小，主要是由 n 决定
            Add(0, e);
        }

        eg. 每次都往数组中间添加一个元素，则 平均需要移动 n/2 个元素，即：O(n/2)，同理忽略 常数 2 的影响 --> O(n)

        2）获取 Get: O(1)

        public E Get(int index)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            return data[index];
        }

        3) 修改 Set:  O(1)

        public void Set(int index, int newE)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            data[index] = newE;
        }

        4) 搜索，包含:  O(n)

        public bool Contains(E e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals.(e))
                    return true;
            }
            return false;
        }

        (a) 当元素存在数组中
            元素在数组 头部 找到：O(1)
            元素在数组 尾部 找到：O(n)
            元素在数组 中间 找到：O(n/2) --> O(n)

        (b) 当元素不存在数组中：
            O(n)
    
        5）删除

        public E RemoveAt(int index)
        {
            if (index < 0 || index >= N)                        // RemoveLast 需要执行 语句 1， RemoveFirst 需要执行 语句 1
                throw new ArgumentException("数组索引越界");

            E del = data[index];                                // RemoveLast 需要执行 语句 2， RemoveFirst 需要执行 语句 2

            for (int i = index + 1; i < N-1; i++)               // RemoveFirst 需要执行 语句 3，n-1 次
            {
                data[i - 1] = data[i];
            }

            N--;                                                // RemoveLast 需要执行 语句 3， RemoveFirst 需要执行 语句 4
            data[N] = default(E);                               // RemoveLast 需要执行 语句 4， RemoveFirst 需要执行 语句 5

            if (N == data.Length/4)                             // RemoveLast 需要执行 语句 5， RemoveFirst 需要执行 语句 6
                ResetCapacity(data.Length/2);

            return del;                                         // RemoveLast 需要执行 语句 6， RemoveFirst 需要执行 语句 7
        }

        public E RemoveLast()          // RemoveLast() 需要执行 语句 6条 --> Time = 6 条语句的执行时间 -->  O(1)
        {
            return RemoveAt(N - 1);
        }

        public E RemoveFirst()        // RemoveFirst() 需要执行 语句 (n+5) 条 --> Time = (n+5) 条语句的执行时间 -->  O(n)      
        {
            return RemoveAt(0); ;
        }

        public void RemoveE(E e)
        {
            int index = IndexOf(e);
            if (index != -1)
            {
                RemoveAt(index);
            }
        }         
 */
    }
}
