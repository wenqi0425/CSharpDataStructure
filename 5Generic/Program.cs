using _5Generic;

// 测试 int 

int[] n = { 1,2,3,4,5,6,7 };

GenericArray<int> arr1 = new GenericArray<int>();

for (int i = 0; i < n.Length; i++)
    arr1.AddLast(n[i]);

Console.WriteLine(arr1);  // Array: count=7 capacity=10，[1, 2, 3, 4, 5, 6, 7]


// 测试 string

string[] s = { "a", "b", "c", "d", "e", "f", "g" };

GenericArray<string> arr2 = new GenericArray<string>();

for (int i = 0; i < s.Length; i++)
    arr2.AddLast(s[i]);

Console.WriteLine(arr2);  // Array: count=7 capacity=10, [a, b, c, d, e, f, g]

Console.Read();
