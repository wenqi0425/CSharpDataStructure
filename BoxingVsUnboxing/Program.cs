using System.Collections;
using System.Diagnostics;

/*
   装箱： 值类型   -->  引用类型
   拆箱： 引用类型 -->  值类型

   引用类型：任何称为 “类” 的类型，都是引用类型，如 string，object
   值类型：  结构 stuct 或 枚举 enum，如 int

   查看一个数据类型，是 引用类型 还是 值类型，用 F12

   int      -->  public struct Int32
   string   -->  public sealed class String
   object   -->  public class Object   

   性能测试要用 Release，而不是 Debug


泛型和非泛型：

泛型数组 List<> 有两个优势：
1）对于存储 值类型 的数据，性能更优
2）使代码更清晰，保证类型安全，LIst只能存储同一种类型的数据。

ArrayList 存储的是 Object 类型的引用类型数据，所以可以混合存储不同类型的数据。已近淘汰。不推荐！

 */

int n = 10000000;     // int 的最大位数是10位

// 计时器 1)，测试值类型对象 int

Stopwatch t1 = Stopwatch.StartNew();
Stopwatch t2 = Stopwatch.StartNew();
Stopwatch t3 = Stopwatch.StartNew();
Stopwatch t4 = Stopwatch.StartNew();

Console.WriteLine("Test Value Type: int");   
t1.Start();  

List<int> int_list = new List<int>();

for (int i = 0; i < n; i++)
{
    int_list.Add(i);        // 不发生 装箱
    int x = int_list[i];   // 不发生 拆箱
}   

t1.Stop();

Console.WriteLine("List's time: " + t1.ElapsedMilliseconds + "ms");   // n是100万，88ms，快一倍 -- n是1000万，179 ms，快10倍


// 计时器 2)，测试引用类型对象 ArrayList for int

Console.WriteLine("Test Referrence Type: ArrayList for int");
t2.Start();

ArrayList a = new ArrayList();

for (int i = 0; i < n; i++)
{
    a.Add(i);               // 发生 装箱, int --> object
    int x = (int)a[i];      // 发生 拆箱, (int)强制将 object --> int
}

t2.Stop();

Console.WriteLine("ArrayList's time: " + t2.ElapsedMilliseconds + "ms");    // n是100万，166ms，慢一倍 -- n是1000万，1710 ms，慢10倍


// 计时器 3)，测试引用类型对象 String 

Console.WriteLine("Test Referrence Type: String");
t3.Start();

List<string> string_list = new List<string>();

for (int i = 0; i < n; i++)
{
    string_list.Add("x");         // 不发生 装箱
    string x = string_list[i];   // 不发生 拆箱
}

t3.Stop();

Console.WriteLine("String's time: " + t3.ElapsedMilliseconds + "ms");    


// 计时器 4)，测试引用类型对象 ArrayList for string

Console.WriteLine("Test Referrence Type: ArrayList for string");     // 274 ms，快50%
t4.Start();

ArrayList b = new ArrayList();

for (int i = 0; i < n; i++)
{
    b.Add("x");                 // 不发生 装箱, string --> object，都是引用类型
    string x = (string)b[i];    // 不发生 拆箱, (string)强制将 object --> string
}

t4.Stop();

Console.WriteLine("ArrayList's time: " + t4.ElapsedMilliseconds + "ms");     // 331 ms，慢50%
