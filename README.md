 # **Условия задачи**

  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.  
  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.  
  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**_Примеры:_**

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

# **Описание алгоритма решения задачи**

1. Пользователь с клавиатуры вводит строковый массив через пробел;
2. Считаем сколько элементов в массиве имеют длину меньше или равную 3 символам;
3. Вводим переменную, в которую записываем значение полученное в пункте 2;
4. Создаем новый строковый массив, размер которого равен переменной из пункта 3:
    + вводим счетчик элементов нового строкового массива переменную k = 0;
    + проверяем длину каждого элемента, используя цикл FOR;
    + если длина элемента меньше или равна 3 символам, то записываем этот элемент в элемент нового массива и увеличиваем счетчик на 1, в противном случае переходим в начало цикла для проверки следующего элемента;
5. Выводим наш новый строковый массив в консоль.

***

### Графическое представление алгоритма решения задачи в виде блок-схемы
![Блок-схема](%D0%B1%D0%BB%D0%BE%D0%BA-%D1%81%D1%85%D0%B5%D0%BC%D0%B0.png)
<br>