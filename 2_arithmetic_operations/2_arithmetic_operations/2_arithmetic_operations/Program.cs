//0saDDev1 25.06.2024

//При выполнении нескольких арифметических операций следует учитывать приоритет операций:
//Инкремент ++, декремент --
//Умножение *, деление /, получение остатка %
//Сложение +, вычитание -

int a = 10;
int b = 2;

Console.WriteLine($"Арифметические операции:");
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);

double ad = 10;
double bd = 3;
double cd = ad / bd; //3.33333333
double z = 10 / 4; //результат равен 2
double z1 = 10.0 / 4.0; //результат равен 2.5

Console.WriteLine(cd);
Console.WriteLine(z);
Console.WriteLine(z1);
Console.WriteLine();

Console.WriteLine($"Получение остатка от деления:");
double x = 10.0;
double z2 = x % 4.0; //результат равен 2
Console.WriteLine(z2);
Console.WriteLine();

//префиксный: ++x
//постфиксный: x++ 
Console.WriteLine($"Постфисный и префиксный инкремент и декремент:");
int q = 5;
int v = ++q; // v=6; q=6
Console.WriteLine($"{q} - {v}");

int x2 = 5;
int z3 = x2++; // z3=5; x2=6
Console.WriteLine($"{x2} - {z3}");

int dq = --q; // q=5; dq=4
Console.WriteLine($"{q} - {dq}");

int z22 = x2--; // z22=5; x2=4
Console.WriteLine($"{x2} - {z22}");


Console.ReadLine();