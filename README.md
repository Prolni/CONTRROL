# *Задание*

1. Скачайте файл контрольной работы справа от урока, решите задачи и направьте файл с выполненной работой в окно загрузки «практического задания» в 5 уроке(Продакт-менеджер) .

2. Пройдите тест и подтвердите специализацию.

# *Итоговая проверочная работа*

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

*Задача:* 

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []




# *Итоговая проверочная работа (I четверть)*

1. Создаем репозиторий CONTRROL.
2. Создаем папки и файлы в разных ветках в VSC - с программой решения задачи, описательным файлом, блок-схемой алгоритма выполнения задачи, gitignore.
3. Добавляем созданные файлы, папки в репозиторий.

## *ЗАДАЧА*
## *Описание решения:*
*  Первоначальный массив задан на старте выполнения алгоритма.
* Параметр массива тип string[].
* Определяется и инициализируется int переменная resultLength для хранения длинны результирующего массива.
* Инкремент в теле цикла for по массиву, определяет количество элементов с длинной менее или равным 3, результат помещается в resultLength.
* Создаем результирующий массив.
* Создаем переменную счетчик для хранения индекса результирующего массива.
* В теле цикла for заполняем результирующий массив строками, с длинной менее или равным 3.
* Если условие не выполняется, итерация не выполняется и счетчик индекса не меняется.
* Возврат результирующего массива.
* Метод printStringArr тип void, принимает массив тип string[] в качестве параметра.
* Дополняем скобки "[ ]" и запятые до предпоследнего индекса.
* Циклом for проходим по массиву, используюя итератор i для вывода значений в консоль.
* Метод printResult тип void, принимает массив тип string[] в качестве параметра.
* Дополняем символ "   →  " и перенос строки.
* Методы: menee3symbol и printStringArr - вывод результата в консоль/на экран.
- result.printResult(array1);
- result.printResult(array2);
- result.printResult(array3);

*В итоге получаем результат:*

[“Hello”, “2”, “world”, “:-)”]  →  [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”]  →  [“-2”]

[“Russia”, “Denmark”, “Kazan”]  →  []

