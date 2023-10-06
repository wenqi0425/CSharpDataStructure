using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LinkedList
{
    internal class MyLinkedList<E>
    { 
        // 创建一个 私有类 Node，属于链表的一部分
        private class Node
        {
            public E e;         // 节点包含的元素
            public Node next;   // 下一个节点的引用

            public Node(E e, Node next)
            {
                this.e = e;
                this.next = next;
            }

            // 当没有下一个节点时
            public Node(E e)
            {
                this.e = e;
                this.next = null;
            }

            // ToString() 打印输出
            public override string ToString()
            {
                return e.ToString();
            }
        }

        // 记录 链表的 头节点
        private Node head;

        // 链表中存储的 元素数量
        private int N;

        // 初始化构造函数
        public MyLinkedList()
        {
            head = null;
            N = 0;
        }

        // 判断链表是否为 空
        public bool IsEmpty
        {
            get { return N == 0; }
        }
    }


}
