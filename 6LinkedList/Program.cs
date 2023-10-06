
/*  静态数组 Static Array 
    
    优点：通过索引就可以直接访问任意元素
    缺点：在初始化的时候，就需要知道元素的数量。预估大了空间浪费，预估小了，空间不够用。

    解决方案：        动态数组 Dynamic Array，能自动调节空间大小，但是还是不能充分利用全部的空间。
    进一步的解决方案： 链表 Lined List，能充分利用空间，并实现灵活的动态内存管理。

    链表 Lined List:  
        1）链表由一个个节点构成
        2）每一个节点存储了两个信息，即：实际存储的元素，和，下一个节点的引用（指针），用于将两个节点进行挂接
        3）将一个又一个节点，进行链接，就形成了链表。 
        4）链表中，只能通过前一个节点，找到后一个节点。
            如   要找 2节点 的值，必须要先找到 1节点，因为 1节点 包含了 2节点 的引用。
                 要找 1节点 的值，必须要先找到 0节点，因为 0节点 包含了 1节点 的引用。
        5）为了找到 0节点，必须要记录链表的 头节点的引用 head
        5）节点的末尾，没有其他的节点，就指向 null。

        0 --> 1 --> 2 --> 3 --> 4 --> null


    封装一个节点
    private class Node
    {
        public E e;         // 节点存储的元素
        public Node next;   // 下一个节点的引用（指针）
    } 

    private Node head；     // 链表的头节点的引用


C# 提供了 链表类
    1）LinkedList<>，是一个双向链表类。
    2) LinkedListNode<>, 双向链表的节点类

    双向链表 不常用。常用的是 单向链表。

 */

using _6LinkedList;

MyLinkedList<int> linkedList = new MyLinkedList<int>();
for (int i = 0;i<5; i++)
{
    linkedList.AddFirst(i);
    Console.WriteLine(linkedList);  // 4 -> 3 -> 2 -> 1 -> 0 -> Null
}

Console.WriteLine();

linkedList.AddLast(88);
Console.WriteLine(linkedList);   // 4 -> 3 -> 2 -> 1 -> 0 -> 88 -> Null
Console.WriteLine();

linkedList.Add(2, 999);
Console.WriteLine(linkedList);   // 4 -> 3 -> 999 -> 2 -> 1 -> 0 -> 88 -> Null
Console.WriteLine();

linkedList.Set(2, 1000);
Console.WriteLine(linkedList);   // 4 -> 3 -> 1000 -> 2 -> 1 -> 0 -> 88 -> Null
Console.WriteLine();

Console.WriteLine(linkedList.Get(2));    // 1000
Console.WriteLine();

Console.WriteLine(linkedList.Contains(100));    // False
Console.WriteLine(linkedList.Contains(1000));   // True
Console.WriteLine();

linkedList.RemoveAt(2);
Console.WriteLine(linkedList);   // 4 -> 3 -> 2 -> 1 -> 0 -> 88 -> Null

linkedList.RemoveFirst();
Console.WriteLine(linkedList);   // 3 -> 2 -> 1 -> 0 -> 88 -> Null

linkedList.RemoveLast();
Console.WriteLine(linkedList);   // 3 -> 2 -> 1 -> 0 -> Null

linkedList.Remove(0);
Console.WriteLine(linkedList);   // 3 -> 2 -> 1 -> Null

Console.Read();




