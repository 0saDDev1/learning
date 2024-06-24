//0saDDev1 24.06.2024


//C# базовые типы данных:
//bool: хранит значение true или false (логические литералы). Представлен системным типом System.Boolean
bool alive = true;
bool isDead = false;
//byte: хранит целое число от 0 до 255 и занимает 1 байт.Представлен системным типом System.Byte
byte bit1 = 1;
byte bit2 = 102;
//sbyte: хранит целое число от -128 до 127 и занимает 1 байт.Представлен системным типом System.SByte
sbyte sbit1 = -101;
sbyte sbit2 = 102;
//short: хранит целое число от -32768 до 32767 и занимает 2 байта.Представлен системным типом System.Int16
short n1 = 1;
short n2 = 102;
//ushort: хранит целое число от 0 до 65535 и занимает 2 байта.Представлен системным типом System.UInt16
ushort n11 = 1;
ushort n22 = 102;
//int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.Представлен системным типом System.Int32.Все целочисленные литералы по умолчанию представляют значения типа int:
int a = 10;
int b = 0b101;  // бинарная форма b =5
int c = 0xFF;   // шестнадцатеричная форма c = 255
                //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта.Представлен системным типом System.UInt32
uint a1 = 10;
uint b1 = 0b101;
uint c1 = 0xFF;
//long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.Представлен системным типом System.Int64
long a11 = -10;
long b11 = 0b101;
long c11 = 0xFF;
//ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.Представлен системным типом System.UInt64
ulong a111 = 10;
ulong b111 = 0b101;
ulong c111 = 0xFF;
//float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта.Представлен системным типом System.Single
float f = 1.86646546465F;
//double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта.Представлен системным типом System.Double
double d = 0.0000000001;
//decimal: хранит десятичное дробное число.
//Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт.
//Представлен системным типом System.Decimal
decimal dd = 0.0111111M;
//char: хранит одиночный символ в кодировке Unicode и занимает 2 байта.Представлен системным типом System.Char.Этому типу соответствуют символьные литералы:
char aa = 'A';
char bb = '\x5A';
char cc = '\u0420';
//string: хранит набор символов Unicode.Представлен системным типом System.String.Этому типу соответствуют строковые литералы.
string hello = "Hello";
string word = "world";
//object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.Представлен системным типом System.Object, который является базовым для всех других типов и классов.NET.
object ao = 22;
object bo = 3.14;
object co = "hi";
//var не явная типизация переменной
var v = "hello world";



Console.Write($"bool:\t\t {alive};{isDead}\t Type: "); Console.WriteLine(alive.GetType());
Console.Write($"byte:\t\t {bit1};{bit2}\t\t Type: "); Console.WriteLine(bit1.GetType());
Console.Write($"sbyte:\t\t {sbit1};{sbit2}\t Type: "); Console.WriteLine(sbit1.GetType());
Console.Write($"short:\t\t {n1};{n2}\t\t Type: "); Console.WriteLine(n1.GetType());
Console.Write($"ushort:\t\t {n11};{n22}\t\t Type: "); Console.WriteLine(n11.GetType());
Console.Write($"int:\t\t {a};{b};{c}\t Type: "); Console.WriteLine(a.GetType());
Console.Write($"uint:\t\t {a1};{b1};{c1}\t Type: "); Console.WriteLine(a1.GetType());
Console.Write($"long:\t\t {a11};{b11};{c11}\t Type: "); Console.WriteLine(a11.GetType());
Console.Write($"ulong:\t\t {a111};{b111};{c111}\t Type: "); Console.WriteLine(a111.GetType());
Console.Write($"float:\t\t {f}\t Type: "); Console.WriteLine(f.GetType());
Console.Write($"double:\t\t {d}\t\t Type: "); Console.WriteLine(d.GetType());
Console.Write($"decimal:\t {dd}\t Type: "); Console.WriteLine(dd.GetType());
Console.Write($"char:\t\t {aa};{bb};{cc}\t\t Type: "); Console.WriteLine(aa.GetType());
Console.Write($"string:\t\t {hello};{word}\t Type: "); Console.WriteLine(hello.GetType());

var s1 = ao.GetType(); var s2 = bo.GetType(); var s3 = co.GetType();
Console.WriteLine($"object:\t\t {ao};{bo};{co}\t Type: {s1} {s2} {s3}");

Console.Write($"var:\t\t {v}\t Type: "); Console.WriteLine(v.GetType());


Console.ReadLine();
