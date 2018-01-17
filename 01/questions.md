Вопросы к лекции 1.
---
### Вопрос 1
Каков результат компиляции и выполнения приведенного ниже кода?
~~~
static void Main(string[] args)
{
    Console.WriteLine(GetSomeResult(10000));
}

static long GetSomeResult(long someValue)
{
    long value1 = 10 * 1000 * 10000 * someValue;
    long value2 = 10 * 1000 * 10000 * 100000;
    return value2 / value1;
}
~~~
### Вопрос 2
Почему следующий код выводит False?
~~~
public static void Main()
{
    Test t = new Test();
    Console.WriteLine(t.Equals(t));
}
~~~
### Вопрос 3
Что следует ожидать на экране?
~~~
public static void Main()
{
    Console.WriteLine("A" + "B" + "C");
	Console.WriteLine('A' + 'B' + 'C');
}
~~~
### Вопрос 4
Циклическая инициализация полей? Интересненько! А что будет на консоли выведено?
~~~
public class A
{
	public static int x = B.y + 1;
}
public class B //плохой код я знаю.
{
	public static int y = A.x + 1;
}

static void Main(string[] args)
{
    Console.WriteLine("A.x = " + A.x);
    Console.WriteLine("B.y = " + B.y);
}
~~~
### Вопрос 5
Что выведет программа и почему?
~~~
...
byte b1 = 1, b2 = 2, b3 = b1 + b2;

if (b3 > b1)
    Console.WriteLine("OK!");
else
    Console.WriteLine("wow!");
...
~~~
