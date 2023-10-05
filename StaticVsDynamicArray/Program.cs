using System.Collections;

int[] arr = new int[10];

// 静态数组的容量固定，如果 i<15，就会造成数组越界，'Index was outside the bounds of the array.'

for (int i = 0; i < 10; i++)
{
    arr[i] = i;
    Console.Write(arr[i] + " "); // 不需要换行，0 1 2 3 4 5 6 7 8 9
}

Console.WriteLine();

// 动态数组

// 动态数组 1） ArrayList
ArrayList a = new ArrayList(10);    // 为了比较，此处也定义容量为10，但其实可以不定义容量
for (int i = 0; i < 10; i++)
{
    a.Add(i);
    Console.Write(a[i] + " ");    // 0 1 2 3 4 5 6 7 8 9
}

Console.WriteLine();


// i < 15 时，会自动扩容

for (int i = 0; i < 15; i++)
{
    a.Add(i);
    Console.Write(a[i] + " ");    // 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4
}

Console.WriteLine();


// 对于新的ArrayList b，数据会自动递增

ArrayList b = new ArrayList(10);
for (int i = 0; i < 15; i++)
{
    b.Add(i);
    Console.Write(b[i] + " ");    // 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14
}

Console.WriteLine();

// 动态数据 2） List<泛型>

List<int> ints = new List<int>(10);
for (int i = 0; i < 15; i++)
{
    ints.Add(i);
    Console.Write(ints[i] + " ");   // 0 1 2 3 4 5 6 7 8 9  -->  0 1 2 3 4 5 6 7 8 9 10 11 12 13 14
};

Console.WriteLine();