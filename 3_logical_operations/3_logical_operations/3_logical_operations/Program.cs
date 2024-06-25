//0saDDev1 25.06.2024

//логические или поразрядные операции
// &(логическое умножение)
Console.WriteLine($"логическое умножение:");
int x1 = 2; //010
int y1 = 5; //101
Console.WriteLine(x1 & y1); // выведет 0

int x2 = 4; //100
int y2 = 5; //101
Console.WriteLine(x2 & y2); // выведет 4
//два числа 2 и 5. 2 в двоичном виде - 010, а 5 - 101. Поразрядно умножим числа (0*1, 1*0, 0*1) и в итоге получим 000.
Console.WriteLine();



// | (логическое сложение)
Console.WriteLine($"логическое сложение:");
int a1 = 2; //010
int b1 = 5;//101
Console.WriteLine(a1 | b1); // выведет 7 - 111
int a2 = 4; //100
int b2 = 5;//101
Console.WriteLine(a2 | b2); // выведет 5 - 101
Console.WriteLine();


// ^ (логическое исключающее ИЛИ XOR)
Console.WriteLine($"логическое ИЛИ:");

// примитивный шифратор
int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
int encrypt = x ^ key; //Результатом будет число 1001011 или 75
Console.WriteLine($"Зашифрованное число: {encrypt}");

int decrypt = encrypt ^ key; // Результатом будет исходное число 45
Console.WriteLine($"Расшифрованное число: {decrypt}");
Console.WriteLine();

// обмен двух положительных чисел без использования дополнительной переменной
int a = 9;  // 1001 
int b = 5;  // 0101
Console.WriteLine($"a: {a}");  
Console.WriteLine($"b: {b}");
a = a ^ b;  // a = 1001 ^ 0101 = 1100 = 12
b = a ^ b;  // b = 12 ^ 5 = 1100 ^ 0101 = 1001 = 9
a = a ^ b;  // a = 12 ^ 9 = 1100 ^ 1001 = 0101 = 5
Console.WriteLine($"a: {a}");  // 5
Console.WriteLine($"b: {b}");  // 9
Console.WriteLine();

// ~ (логическое отрицание или инверсия)
Console.WriteLine($"логическое отрицание:");
int q = 12;                 // 00001100
Console.WriteLine(~q);      // 11110011   или -13
Console.WriteLine();

Console.ReadLine();