//0saDDev1 27.06.2024

//Операции сравнения
Console.WriteLine($"Операции сравнения:");
// == Сравнивает два операнда на равенство. Если они равны, то операция возвращает true, если не равны, то возвращается false:
Console.WriteLine($"операция ==:");
int a = 10;
int b = 4;
bool c = a == b; // false
Console.WriteLine($"a={a} b={b} a==b {c}");

// != Сравнивает два операнда и возвращает true, если операнды не равны, и false, если они равны.
Console.WriteLine($"операция !=:");
int a1 = 10;
int b1 = 4;
bool c1 = a1 != b1;    // true
Console.WriteLine($"a={a1} b={b1} a!=b {c1}");
bool d1 = a1 != 10;     // false
Console.WriteLine($"a={a1} a!=10 {d1}");


// < Операция "меньше чем".Возвращает true, если первый операнд меньше второго, и false, если первый операнд больше второго:
Console.WriteLine($"операция <:");
int a2 = 10;
int b2 = 4;
bool c2 = a2 < b2; // false
Console.WriteLine($"a={a2} b={b2} a<b {c2}");

// > Операция "больше чем".Сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false:
Console.WriteLine($"операция >:");
int a3 = 10;
int b3 = 4;    
Console.WriteLine($"a={a3} b={b3} a>b {a3 > b3}");// true   
Console.WriteLine($"a={a3} a>25 {a > 25}");// false

// <= Операция "меньше или равно".Сравнивает два операнда и возвращает true, если первый операнд меньше или равен второму. Иначе возвращает false.
Console.WriteLine($"операция <=:");
int a4 = 10;
int b4 = 4;  
Console.WriteLine($"a={a4} b={b4} a<=b {a4 <= b4}");// false   
Console.WriteLine($"a={a4} a<=25 {a4 <= 25}");// true

// >= Операция "больше или равно".Сравнивает два операнда и возвращает true, если первый операнд больше или равен второму, иначе возвращается false:
Console.WriteLine($"операция >=:");
int a5 = 10;
int b5 = 4;
Console.WriteLine($"a={a5} b={b5} a>=b {a5 >= b5}");// true
Console.WriteLine($"a={a4} a>=25 {a5 >= 25}");// false

//Операции<,> <=, >= имеют больший приоритет, чем == и !=.

//Логические операции
Console.WriteLine($"Логические операции:");

// | Операция логического сложения или логическое ИЛИ. Возвращает true, если хотя бы один из операндов возвращает true.
bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
Console.WriteLine(x1);
bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
Console.WriteLine(x2);

// & Операция логического умножения или логическое И. Возвращает true, если оба операнда одновременно равны true.
bool x11 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
Console.WriteLine(x11);
bool x22 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
Console.WriteLine(x22);

// || Операция логического сложения. Возвращает true, если хотя бы один из операндов возвращает true.
bool x111 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
Console.WriteLine(x111);
bool x222 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
Console.WriteLine(x222);

// && Операция логического умножения. Возвращает true, если оба операнда одновременно равны true.
bool x1111 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
Console.WriteLine(x1111);
bool x2222 = (5 < 6) && (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
Console.WriteLine(x2222);

// ! Операция логического отрицания. Производится над одним операндом и возвращает true, если операнд равен false. Если операнд равен true, то операция возвращает false:
bool aa = true;
bool bb = !aa;    // false
Console.WriteLine(bb);

// ^ Операция исключающего ИЛИ. Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, иначе возвращает false
bool x5 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
Console.WriteLine(x5);
bool x6 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false
Console.WriteLine(x6);

Console.ReadLine();
