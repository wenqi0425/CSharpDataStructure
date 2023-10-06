using _3DynamicArray;

MyDynamicArray arr = new MyDynamicArray(10);

for (int i = 0;i<10;i++)
    arr.AddLast(i);     // 将数组填满

// 在 Console.Write之类的方法中，ToString() 会被默认使用。 
Console.WriteLine(arr);  // Array: count=10 capacity=10，[0, 1, 2, 3, 4, 5, 6, 7, 8, 9] 
Console.WriteLine();

arr.AddFirst(55);
Console.WriteLine(arr);  // Array: count=11 capacity=20，[55, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9] 
Console.WriteLine();

arr.RemoveE(55);
Console.WriteLine(arr);  // Array: count=10 capacity=20，[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
Console.WriteLine();

for (int i = 0; i < 6; i++)
{
    arr.RemoveAt(i);     // 删除从0-5的6个元素，因为是动态排序，所以会先删除所有的偶数
    Console.WriteLine(arr);
}

/*  结果：
Array: count=9 capacity=20
[1, 2, 3, 4, 5, 6, 7, 8, 9]    // 0
Array: count=8 capacity=20
[1, 3, 4, 5, 6, 7, 8, 9]       // 2
Array: count=7 capacity=20
[1, 3, 5, 6, 7, 8, 9]          // 4
Array: count=6 capacity=20
[1, 3, 5, 7, 8, 9]             // 6
Array: count=5 capacity=10
[1, 3, 5, 7, 9]                // 8
Array: count=4 capacity=10
[1, 3, 5, 7]                   // 9
*/


Console.Read();