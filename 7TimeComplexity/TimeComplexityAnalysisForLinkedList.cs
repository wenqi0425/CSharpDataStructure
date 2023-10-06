using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _7TimeComplexity
{
    internal class TimeComplexityAnalysisForLinkedList
    {
        /* 链表 的 时间复杂度 分析
         1） 添加：
        
        public void Add(int index, E e)                              
        {
            if( index < 0 || index > N)                             // AddFirst 需要执行 语句 1， AddLast 需要执行 语句 1
                throw new IndexOutOfRangeException("非法索引");

            if (index == 0)                                         // AddFirst 需要执行 语句 2， AddLast 需要执行 语句 2                    
            {
                head = new Node(e, head);                           // AddFirst 需要执行 语句 3 
            }

            else
            {
                Node preIndex = head;                               // AddLast 需要执行 语句 3

                for(int i = 0; i<index-1; i++)
                    preIndex = preIndex.next;                       // AddLast 需要执行 语句 4. n-1 次 

                preIndex.next = new Node(e, preIndex.next);         // AddLast 需要执行 语句 5
            }

            N++;                                                    // AddFirst 需要执行 语句 4， AddLast 需要执行 语句 6
        }

        public void AddFirst(E e)        // AddFirst 需要执行 语句 4 条  --> Time = 4 条语句的执行时间  -->  O(1)
        {
            Add(0, e);
        }

        public void AddLast(E e)        // AddLast 需要执行 语句 (n+4) 条  --> Time = (n+4) 条语句的执行时间  -->  O(n)
        {
            Add(N, e);
        }

        2）查找
        public E Get(int index)                                     
        {
            if (index < 0 || index >= N)                            // GetFirst 需要执行 语句 1， GetLast 需要执行 语句 1
                throw new IndexOutOfRangeException("非法索引");

            Node current = head;                                    // GetFirst 需要执行 语句 2， GetLast 需要执行 语句 1
            for (int i = 0; i < index; i++)                         // GetLast 需要执行 语句 3, n-1 次
                current = current.next;

            return current.e;                                       // GetFirst 需要执行 语句 3， GetLast 需要执行 语句 4
        }

        public E GetFirst()         // GetFirst 需要执行 语句 3 条  --> Time = 3 条语句的执行时间  -->  O(1)
        {
            return Get(0);
        }

        public E GetLast()          // GetLast 需要执行 语句 (n+2) 条  --> Time = (n+2) 条语句的执行时间  -->  O(n)
        {
            return Get(N - 1);
        }

        3）查询
        public bool Contains(E e)
        {
            Node current = head;
            while (current != null)
            {
                if (current.e.Equals(e))
                    return true;

                current = current.next;
            }

            return false;
        }

        (a) 当元素存在 链表 中
            元素在链表 头部 找到：O(1)
            元素在链表 尾部 找到：O(n)
            元素在链表 中间 找到：O(n/2) --> O(n)

        (b) 当元素不存在链表中：
            O(n)

        4）删除
        public E RemoveAt(int index)
        {
            if (index < 0 || index >= N)                            // RemoveFirst 需要执行 语句 1， RemoveLast 需要执行 语句 1 
                throw new IndexOutOfRangeException("非法索引");

            if (index == 0)                                         // RemoveFirst 需要执行 语句 2， RemoveLast 需要执行 语句 2
            {
                Node delNode = head;                                // RemoveFirst 需要执行 语句 3
                head = head.next;                                   // RemoveFirst 需要执行 语句 4
                N--;                                                // RemoveFirst 需要执行 语句 5
                return delNode.e;                                   // RemoveFirst 需要执行 语句 6
            }
            else
            {
                Node preIndex = head;                               // RemoveLast 需要执行 语句 3
                for (int i = 0; i < index - 1; i++)
                    preIndex = preIndex.next;                       // RemoveLast 需要执行 语句 4，n-2 次

                Node delNode = preIndex.next;                       // RemoveLast 需要执行 语句 5 
                preIndex.next = delNode.next;                       // RemoveLast 需要执行 语句 6
                N--;                                                // RemoveLast 需要执行 语句 7
                return delNode.e;                                   // RemoveLast 需要执行 语句 8
            }
        }

        public E RemoveFirst()          // RemoveFirst 需要执行 语句 6 条  --> Time = 6 条语句的执行时间  -->  O(1)
        {
            return RemoveAt(0);
        }
            
        public E RemoveLast()           // RemoveFirst 需要执行 语句 (n+5) 条  --> Time = (n+5) 条语句的执行时间  -->  O(n)
        {
            return RemoveAt(N - 1);
        }
    */
    }
}
