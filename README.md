# 🧪 Обучающий пример Unit тестирования кода C# при помощи MSTest + Алгоритм "Решето Эратосфена"

Этот проект представляет собой обучающий пример работы с тестированием функции, реализующей алгоритм "Решето Эратосфена" с использованием библиотеки MSTest в C#. Внутри проекта реализован сервис `PrimeService`, который проверяет, является ли переданное число простым. Также реализованы тесты, проверяющие корректность работы этого сервиса.

## 📚 Алгоритм "Решето Эратосфена"

Данный алгоритм используется для поиска всех простых чисел до заданного числа. Он работает следующим образом:

Создается массив чисел от 2 до N, где N - это число, до которого вы хотите найти простые числа.

Начиная с числа 2 (первого простого числа), все его кратные числа помечаются как составные.

Затем переходят к следующему непомеченному числу и повторяют этот процесс, пока не исчерпают все числа последовательности.

Непомеченные числа являются простыми.
___
В данной реализации мы не создаём массив чисел в некотором диапазоне явно, а просто используем этот же алгоритм для определения "простоты" единственного подаваемого на вход числа.

Реализация IsPrime в классе PrimeService проверяет, является ли число простым. 

Он сначала выполняет несколько базовых проверок.

***Исключение чисел меньше или равных 1:*** Сначала мы проверяем, если число меньше или равно 1, то оно не считается простым, и мы возвращаем false.

***Исключение чисел 2 и 3:*** Если число равно 2 или 3, оно считается простым, и мы возвращаем true.

***Исключение четных чисел и чисел, кратных 3:*** Если число делится на 2 или 3 без остатка, то оно не является простым. Мы проверяем это с помощью операторов number % 2 == 0 и number % 3 == 0, и если одно из них выполняется, возвращаем false.

***Использование проверки делителей:*** Далее мы используем оптимизированную проверку делителей, основанную на том факте, что все простые числа больше 3 имеют форму 6k ± 1, где k - натуральное число. Мы начинаем проверку с i = 5 и увеличиваем i на 6 на каждой итерации.

***Проверка деления:*** На каждой итерации мы проверяем, делится ли число на i без остатка, а также на i + 2. Если хотя бы одно из этих условий выполняется, то число не является простым.

***Возвращение результата:*** Если число не делится на ни один из проверяемых делителей, то оно считается простым, и мы возвращаем true.



##  Тестирование

`IsPrime_InputsPrimes_ReturnTrue`: В этом методе мы проверяем, что функция правильно определяет, что заданные числа (5, 7, 11, 29, 43, 47) являются простыми. Мы ожидаем, что функция вернет true, и используем Assert.IsTrue для проверки этого. Если функция вернет true, тест проходит.

`IsPrime_ValuesLessThan3OrEqual3_ReturnTrue`: Этот метод тестирует числа, меньшие или равные 3 (то есть 2 и 3). Мы ожидаем, что функция также вернет true для этих чисел.

`IsPrime_InputsLessThan1OrEqual1_ReturnFalse`: Здесь мы проверяем числа, меньшие или равные 1 (то есть -1, 0, и 1). Ожидаем, что функция вернет false, так как они не являются простыми числами.

`IsPrime_InputsNotPrimes_ReturnTrue`: В этом методе мы проверяем числа, которые не являются простыми (4, 8, 12, 33, 48, 74). Мы ожидаем, что функция вернет false, и тест пройдет, если это условие выполняется.

## ▶️ Запуск проекта

Чтобы запустить тесты, выполните следующие шаги:

1. Склонируйте репозиторий на свой компьютер.

2. Откройте проект в вашей среде разработки C# (например, Visual Studio).

3. Восстановите библиотеки, необходимые для работы проекта командой ```dotnet restore``` в терминале.

4. Запустите тесты командой ```dotnet test```.

## 📚 Учебный материал

Этот краткий пример призван помочь освоить азы Unit-тестирования и не претендует на полноту изложения материала. Читайте статьи и документацию по теме ([например, почитайте про нейминг тестов](https://bool.dev/blog/detail/kak-pravilno-imenovat-unit-testu)) - и будет вам счастье ☀️


Вы можете использовать этот проект как учебный материал для изучения тестирования и оптимизации алгоритма проверки чисел на простоту в C#. Создавайте собственные тесты на основе этого проекта, экспериментируйте и углубляйтесь в тему тестирования программного обеспечения. Помните о важности изучения алгоритмов и удачи! 🚀
