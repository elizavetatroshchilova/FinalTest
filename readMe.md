**План решения контрольной работы**

1. Создать локальный репозиторий
2. Создать блок-схему решения задачи.
3. Поместить блок-схему в текущий репозиторий. (*сделать коммит*)
4. Описать решение задачи. (*сделать коммит*)
5. Написать код, решающий поставленную задачу. (*сделать коммит*)
6. Создать удаленный репозиторий на GItHub.
7. Сделать push локального репозитория в удаленный.

*Ниже прикрепляю схему решения задачи:*

![блок-схема](kontr.png)

**Решение задачи по пунктам**

>Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

1. Создаем первый массив firstArray и задаем значение элементов {Russia; cat; -0987; :); France; 12}. Элементы могут быть асболютно разными.
2. Вводим счетчик под названием count и задаем значение = 0.
3. Создаем цикл for, с счетчиком i, который будет работать, пока i < длина первого массива firstArray (i++ - инкремент).
4. Внутри цикла создаем условие if и проверяем длину элемента. Если она меньше или равна 3, то увеличиваем счетчик на 1. Если длина элемента больше 3, то просто переходим к следующему элементу.

5. Выходим из первого цикла и создаем новый массив secondArray c длиной равной счетчику count.
6. Задаем счетчик j для второго массива.
7. Создаем новый цикл for с четчиком i, который будет работать, пока i < firstArray.Length (i++ - инкремент).
8. Внутри цикла создаем условие if и снова проверяем длину элемента первого массива. Если она меньше или равна 3, то помещаем данный элемент во второй массив. Если длина элемента больше 3 символов, пропускаем элемент и переходим к следующему.
9. После выхода из второго цикла печатаем первоначально заданный массив и второй массив, содержащий в себе только подходящие элементы первого.


