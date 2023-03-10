# Знакомство с языками программирования.

Данный репозиторий содержит практические задания по программированию на языке **С#**.

## Немного теории.

**Знакомство с языком программирования C#**

На сегодняшний момент язык программирования C# один из самых мощных, быстро развивающихся и востребованных языков в ИТ-отрасли. В настоящий момент на нем пишутся самые различные приложения:

*  проекты для мобильных телефонов, используя фреймворк Xamarin.
*  игры, используя игровой движок Unity, где С# выступает скриптовым языком.
*  десктопные приложения для Windows и Mac OS.
*  веб-проекты.
*  технически можно даже создавать проекты для «интернета вещей».

В конце 90-х - начале 00-х Microsoft решила конкурировать с Sun microsystems и её набиравшим популярность языком Java. Аналогом платформы Java RE стала платформа Dotnet, а соперником языка Java — язык С#. На старте С# очень многое взял из других языков, например, из С++ и Java, поэтому они очень похожи. Однако позднее, уже Java, начала многое заимствовать у С#.

> **Язык программирования - это инструмент.**

**Первая прогрмма.**

Прежде всего для написания кода программы понадобится текстовый редактор. В принципе можно выбрать любой понравившийся текстовый редактор. Наиболее популярный [Visual Studio Code](https://code.visualstudio.com/Download). Данный текстовый редактор доступен для всех основных операционных систем: Windows, MacOS, Linux.

Второй необходимый компонент для создания программ - компилятор. Для компиляции, построения, запуска и ряда других задач Microsoft предоставляет набор инструментов, который называется [.NET SDK](https://dotnet.microsoft.com/en-us/download).

После установки редактора и компилятора, необходимо перезагрузить систему. После перезагрузки необходимо перейти в Visual Studio Code. На вкладке расширений («extension») вводим «С#». Первым пунктом отобразится расширение С#. Обратите внимание на разработчика — это официальный пакет Microsoft, его и необходимо установить.

Для того, чтобы подготовить папку для написания проекта, нужно ввести следующую команду: *dotnet new console*.

По умолчанию создается главный файл программы **Program.cs**

Для запуска проекта в командной строке вводится следующая команда: *dotnet run*.

**Некоторые методы вывода в консоль:**

* Через *Console* мы обращаемся к окну терминала.
* *Console.WriteLine* - вывод с переходом на новую строку
* *Console.Write* - вывод в одну строку

**Считывание из консоли:**
* *Console.ReadLine* - считывает строку из терминала

**Типы данных.**

* *int* - целые числа (32-разрядное целое число)
* *double* - целое число со знаком (64-разрядное)
* *string* - строка (от 0 до много символов)
* *bool* - логический тип (true, false)

**Методы в С#.**

Если переменные хранят некоторые значения, то методы содержат собой набор инструкций, которые выполняют определенные действия. По сути метод - это именованный блок кода, который выполняет некоторые действия.

Общее определение методов выглядит следующим образом:

*возвращаемый_тип_данныx название_метода ([параметры])*

*{*

    *// тело метода*

    *// return ЗначениеСоответствующееВозвращаемомуТипуДанных;*

*}*

> Параметры в методе необязательны. 

К названиям методов предъявляются в принципе те же требования, что и к названиям переменных. Однако, как правило, названия методов начинаются с большой буквы.

Тип **void** указыает, что фактически ничего не возвращает, он просто производит некоторые действия. Поэтому в методе с типом *void* оператор *return* не используется.

Оператор *return* не только возвращает значение, но и производит выход из метода.

**Параметры** позволяют передать в метод некоторые входные данные. Параметры определяются через заятую в скобках после названия метода в виде:

*тип_метода имя_метода (тип_параметра1 параметр1, тип_параметра2 параметр2, ...)*

*{*

    *// действия метода*
    
*}*

Определение параметра состоит из двух частей: сначала идет тип параметра и затем его имя.

Чтобы использовать метод надо его вызвать. Для вызова метода указывается его имя, после которого в скобках идут значения для его параметров (если метод принимает параметры).

*название_метода (значения_для_параметров_метода);*

Значения, которые передаются параметрам, еще называются аргументами.

При передаче значений параметрам важно учитывать тип параметров: между аргументами и параметрами должно быть соответствие по типу.

**Лоигические операции.**

Также в C# определены логические операторы, которые также возвращают значение типа *bool(true, false)*. В качестве операндов они принимают значения типа *bool(true, false)*. Как правило, применяются к отношениям и объединяют несколько операций сравнения.

* **||** - оператор логическое ИЛИ, операция логического сложения. Возвращает *true*, если хотя бы один из операндов возвращает *true*.

* **&&** - оператор логическое И, операция логического умножения. Возвращает *true*, если оба операнда одновременно равны *true*.

* **!** - оператор отрицания, логическое НЕ.

* **^** - операция исключающего ИЛИ. Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, иначе возвращает false.

**Операции сравнения**

Отдельный набор операций представляет условные выражения. Такие операции возвращают логическое значение, то есть значение типа *bool: true*, если выражение истинно, и *false*, если выражение ложно. К подобным операциям относятся операции сравнения и логические операции.

* **==** - сравнивает два операнда на равенство. Если они равны, то операция возвращает true, если не равны, то возвращается false.

* **!=** - сравнивает два операнда и возвращает true, если операнды не равны, и false, если они равны.

* **<** - операция "меньше чем". Возвращает true, если первый операнд меньше второго, и false, если первый операнд больше второго.
  
* **>** - операция "больше чем". Сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false.

* **<=** - операция "меньше или равно". Сравнивает два операнда и возвращает true, если первый операнд меньше или равен второму. Иначе возвращает false.

* **>=** - операция "больше или равно". Сравнивает два операнда и возвращает true, если первый операнд больше или равен второму, иначе возвращается false.

**Массивы**

Массив представляет набор однотипных данных. Объявление массива похоже на объявление переменной за тем исключением, что после указания типа ставятся квадратные скобки:

*тип_переменной[ ] название массива*

После определения переменной массива мы можем присвоить ей определенное значение:

*тип_переменной[ ] название массива = new тип_значения[длина массива]*

Для типа int значение по умолчанию - 0.

Также мы сразу можем указать значения для этих элементов:

*int[ ] nums2 = new int[4] { 1, 2, 3, 5 };*
 
*int[ ] nums3 = new int[ ] { 1, 2, 3, 5 };*
 
*int[ ] nums4 = new[ ] { 1, 2, 3, 5 };*
 
*int[ ] nums5 = { 1, 2, 3, 5 };*

Все перечисленные выше способы будут равноценны.

Для обращения к элементам массива используются индексы. Индекс представляет номер элемента в массиве, при этом нумерация начинается с нуля, поэтому индекс первого элемента будет равен 0.

*массив[индекс элемента]*

Используя индексы, можно получить значение элемента или можно изменить это значение.

Каждый массив имеет свойство Length, которое хранит длину массива.

*имя_массива.Length* - длина массива