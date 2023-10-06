using _2StaticArray;


// CRUD Static Array

// 插入
MyStaticArray arr = new MyStaticArray(20);   // 必须要大于10，否则会越界

for (int i = 0; i < 10; i++)
{
    arr.AddLast(i);
}

Console.Write(arr);   // 如果没有 ToString() --> DataStructure.Array1, 通过 ToString() 转化为 Array1: count=10 capacity=20，[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
Console.WriteLine();

arr.AddFirst(66);
Console.Write(arr);  // Array: count=11 capacity=20， [66, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
Console.WriteLine();

arr.AddLast(88);
Console.Write(arr);  // Array: count=12 capacity=20 [66, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 88]
Console.WriteLine();

arr.Add(2, 77);
Console.Write(arr);  // Array: count=13 capacity=20 [66, 0, 77, 1, 2, 3, 4, 5, 6, 7, 8, 9, 88]
Console.WriteLine();

// 获取
Console.Write(arr.GetFirst());  // 66
Console.WriteLine();

Console.Write(arr.GetLast());  // 88
Console.WriteLine();

Console.Write(arr.Get(5));  // 3
Console.WriteLine();

/*Console.Write(arr.Get(50));  // 数组索引越界
Console.WriteLine();*/

// 修改
arr.Set(5, 1000);
Console.Write(arr.Get(5));  // 1000
Console.WriteLine();

// 包含
Console.Write(arr.Contains(50) + "," + arr.IndexOf(50));  // False, -1
Console.WriteLine();
Console.Write(arr.Contains(1000) + "," + arr.IndexOf(1000));  // True, 5
Console.WriteLine();

// 删除
Console.Write(arr);    // 当前数组 Array1: count=13 capacity=20，[66, 0, 77, 1, 2, 1000, 4, 5, 6, 7, 8, 9, 88]
Console.WriteLine();
arr.RemoveAt(4);       // 删除 第5个元素，2
arr.RemoveE(4);           // 删除 4 这个元素
arr.RemoveFirst();           // 删除第一个元素，66
arr.RemoveLast();            // 删除最后一个元素，88
Console.Write(arr);    // Array1: count=9 capacity=20， [0, 77, 1, 1000, 5, 6, 7, 8, 9]
Console.WriteLine();

Console.Read();     // 暂停
