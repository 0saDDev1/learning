//0saDDev1 27.06.2024

// Конструкция if..else и тернарная операция
// if
int num1 = 8;
int num2 = 6;


if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
// Если блок if содержит одну инструкцию, то мы можем его сократить, убрав фигурные скобки
if (num1 > num2)
    Console.WriteLine($"Число {num1} больше числа {num2}");
// или так
if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");
//Также мы можем соединить сразу несколько условий, используя логические операторы:
if (num1 > num2 && num1 == 8)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
//во всех примерах блок if будет выполняться, только если условие/-я true

// if else
// else можно читать, как если не, то выполнится else
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}
//Если блок else содержит толко одну инструкцию, то оять же мы можем его сократить, убрав фигурные скобки:
if (num1 > num2)
    Console.WriteLine($"Число {num1} больше числа {num2}");
else
    Console.WriteLine($"Число {num1} меньше числа {num2}");

// else if
// вслучаях когда условий для проверки больше, необходимо использовать else if
string name = "Alex";

if (name == "Tom")
    Console.WriteLine("Вас зовут Tomas");
else if (name == "Bob")
    Console.WriteLine("Вас зовут Robert");
else if (name == "Mike")
    Console.WriteLine("Вас зовут Michael");
else
    Console.WriteLine("Неизвестное имя");

//Тернарная операция
//[первый операнд - условие] ? [второй операнд] : [третий операнд]
//если условие равно true, то возвращается второй операнд; если условие равно false, то третий
int x = 3;
int y = 2;

int z = x < y ? (x + y) : (x - y);
Console.WriteLine(z);   // 1



Console.ReadLine();
