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

        // 添加：
        public void Add(int index, E e)
        {
            if(index<0 || index>N)
                throw new IndexOutOfRangeException("非法索引");

            // 1) 往链表的头部添加元素

            if (index == 0)
            {
                /*
                Node node = new Node(e);
                node.next = head;
                head = node;*/

                // 优雅的写法
                head = new Node(e, head);
            }

            // 2）往链表的中部 或 尾部 添加元素
            else
            {
                // 插入数值到特定节点 index 时，需要先找到 它的前一个节点 preIndex，从头部开始找
                Node preIndex = head;

                // 找到 index 的前一个节点， index-1
                for(int i = 0; i < index-1; i++)
                    // 从头部开始查找，依次往后移动指针，直到找到 index 的前一个节点为止
                    preIndex = preIndex.next;

                /*
                // 为 数值 e 创建一个新的节点 node
                Node node = new Node(e);

                // 将 node 和 preIndex 挂接
                node.next = preIndex.next;
                preIndex.next = node;*/

                // 优雅的写法
                preIndex.next = new Node(e, preIndex.next);
            }

            N++;
        }

        public void AddFirst(E e)
        {
            Add(0, e);
        }

        public void AddLast(E e)
        {
            Add(N, e);
        }
    }
}
