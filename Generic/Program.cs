using _5Generic;

// 测试 int 

int[] n = { 1,2,3,4,5,6,7 };

GenericArray<int> array = new GenericArray<int>();

for (int i = 0; i < n.Length; i++)
    array.AddLast(n[i]);

Console.WriteLine(array);















Console.Read();
