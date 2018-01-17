Курс по языку программирования C# и .NET
====

Темы курса
---
 * *Лекция 1.* Основы
    * Языки программирования и их типы [тык](https://tproger.ru/translations/programming-concepts-compilation-vs-interpretation/)
        * Компилируемые языки. Компиляторы
        * Интерпретируемые языки. Интерпретаторы
        * Языки "типа" `java` и `C#`
        * Плюсы и минусы подобных подходов
    * Принцип работы платформы .NET [тык](https://metanit.com/sharp/tutorial/1.1.php)
        * Виртуальная машина и CLR (байт-код)
        * Сборка мусора [тык^](https://habrahabr.ru/post/125968/) и [MSDN тык](https://msdn.microsoft.com/ru-ru/library/0xy59wtx(v=vs.110).aspx)
        * Управляемый и не управляемый код
        * `JIT (Just-In-Time)` - компиляция
        * Кроссплатформенность
    * Хранение объектов в памяти компьютера
	    * Стек и куча [тык](https://tproger.ru/translations/programming-concepts-stack-and-heap/) и [тык](https://www.youtube.com/watch?v=uVoZbHP41CY)
    * Типы данных в C# [тык](https://metanit.com/sharp/tutorial/2.1.php)
	    * `bool`
	    * `byte`
	    * `sbyte`
	    * `short`
	    * `ushort`
	    * `int`
	    * `uint`
	    * `long`
	    * `ulong`
	    * `float`
	    * `double`
	    * `decimal`
	    * `char`
	    * `string`
	    * `object`
	    * Системные типы (`System.Int32`)
		    * "Обертки" к системным типам (`int` - `Int32`)
    * Понятия класса (`class`) и структуры (`struct`) [тык класс](https://metanit.com/sharp/tutorial/3.1.php) и [тык структура](https://metanit.com/sharp/tutorial/2.13.php)
	    * Отличия [тык еще раз](https://www.youtube.com/watch?v=uVoZbHP41CY)
		    * Ключевое слово `new`
		    * Хранения в памяти компьютера
		    * Ссылочные типы данных
	    * Сходства
	    * Области применения структур [тык MSDN^](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/using-structs)
	    * Ключевое слово `static` [тык](https://habrahabr.ru/post/206082/) и [тык MSDN](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)
		    * Статические и не статические поля класса
		    * Статистические классы
    * Модификаторы доступа [тык](https://metanit.com/sharp/tutorial/3.2.php)
	    * `public`
	    * `protrcted`
	    * `private`
	    * `internal`
    * Парадигмы ООП [тык](https://tproger.ru/translations/diving-in-oop-p1/)
	    * *Наследование*
	    * *Инкапсуляция*
	    * *Полиморфизм*
		    * Ключевое слово `override`
		    * Переопределение и перегрузка методов
	    * Абстракция
	    * Посылка сообщений
	    * Повторное использование
	    * Агрегация [тык^](https://ru.stackoverflow.com/questions/596697/%d0%90%d0%b3%d1%80%d0%b5%d0%b3%d0%b0%d1%86%d0%b8%d1%8f-%d0%b8-%d0%ba%d0%be%d0%bc%d0%bf%d0%be%d0%b7%d0%b8%d1%86%d0%b8%d1%8f)
	    * Композиция [тык (Осторожно JAVA)^](https://habrahabr.ru/post/325478/)
    * Инициализация
	    * Статические и не статические инициализаторы
		    * Инициализация констант
	    * Конструктор [тык](http://mycsharp.ru/post/26/2013_07_03_konstruktory_v_si-sharp_operator_this.html) или [тык MSDN](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/constructors)
		    * Конструктор по умолчанию [тык^](https://habrahabr.ru/post/152118/)
		    * Перегрузка конструкторов
		    * Ключевое слово `this`
	    * Три способа инициализации и их применение [тык](http://plssite.ru/csharp/csharp_object_init_article.html) и [ТЫК (Сложна)^^](https://habrahabr.ru/post/247047/)
    * Области видимости переменных [тык](https://metanit.com/sharp/tutorial/2.18.php)
    * C# - объектный язык
	    * Класс `object` и его методы [тык](https://metanit.com/sharp/tutorial/3.10.php)
	    * Приведение типов [тык](https://professorweb.ru/my/csharp/charp_theory/level3/3_8.php)
	    * Упаковка и распаковка [тык^](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/types/boxing-and-unboxing)