# Итоговая проверочная работа

**Задача :** Написать программу, которая из имеющегося массива строк формирует массив из cтрок, длина которых меньше либо равна 3 символа.

* _Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма._

* _При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами._

### Описание алгоритма решения:

1. Сначало создадим блок-схему решения алгоритма.

2. Объявляется два массива: 
* изначальный (**inputArray**) и вторый такой же длины (**outputArray**).

3. Вводим метод, в котором цикл соразмерный длине массива, внутри цикла проверка условия ( **inputArray[i].Length <= 3** ), если **ДА** элемент первого массива заносится в **count** значение элемент второго массива. Переменная **count** чтобы поочередно закидывать из первого массива во второй и чтобы потом не было пробелов. 

4. После присвоения увеличивается переменная **count** на 1 и возвращается к циклу **for** в котором **i** увеличивается на 1. И так проверяется до конца.

### Блок-схема решения алгоритма программ находится в файле BS.drawio.png
### Алгоритм решения программы находится папке Decision/Programs.cs

#### Решил задачу студент курса разработчик Земчик Д.А.