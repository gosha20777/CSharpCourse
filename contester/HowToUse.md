Инструкция по использованию
---
### 1 способ

1. Поместить файлы `easy.txt` и `hard.txt` нужного теста в папку с `Contester.exe`.
2. Поместить исполняемый файл программы в папку с `Contester.exe`.
3. Запустить `Contester.exe`, написать имя программы и выбрать режим.

*Пример*
~~~
Contester. Created by gosha 20777.

Enter program name: SumConsole
Enter mode [easy] [hard]: easy

Testing...
Test 1  Time 33 ms      SUCSESS!
Test 2  Time 30 ms      FAIL AZAZA!
Press any key to exit...
~~~

### 2 способ

1. Поместить файлы `easy.txt` и `hard.txt` нужного теста в папку с `Contester.exe`.
2. Запустить Contester из командной строки с параметрами `[имя программы] [режим]` 

*Пример*
~~~
C:\temp\> Contester C:\programs\SumConsole hard
~~~

или

~~~
C:\programs\> Contester SumConsole hard
Contester. Created by gosha 20777.

Testing...
Test 1  Time 33 ms      SUCSESS!
Test 2  Time 30 ms      SUCSESS!
Test 3  Time 30 ms      SUCSESS!
Press any key to exit...
~~~