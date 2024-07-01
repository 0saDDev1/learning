//0saDDev1 01.07.2024

//МАССИВЫ
//тип_переменной[] название_массива;

int[] nums = new int[4];

string[] people = { "Tom", "Sam", "Bob" };
//с версии C# 12 для определения массивов можно использовать выражения коллекций, которые предполагают заключение элементов массива в квадратные скобки
int[] nums1 = [1, 2, 3, 5];
int[] nums2 = [];   // пустой массив

int[] numbers = { 1, 2, 3, 5 };
// получение элемента массива
Console.WriteLine(numbers[3]);  // 5
// получение элемента массива в переменную
var n = numbers[1];     // 2
Console.WriteLine(n);  // 2

// изменим второй элемент массива
numbers[1] = 505;
Console.WriteLine(numbers[1]);  // 505

//длинна массива Length
Console.WriteLine(numbers.Length);  // 4

//с версии C# 8.0 в язык был добавлен специальный оператор ^, с помощью которого можно задать индекс относительно конца коллекции
Console.WriteLine(numbers[^1]);  // 5 - первый с конца или последний элемент
Console.WriteLine(numbers[^2]);  // 3 - второй с конца или предпоследний элемент
Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца


//Перебор массивов
int[] numbers1 = { 1, 2, 3, 4, 5 };
foreach (int i in numbers1)
{
    Console.WriteLine(i);
}

for (int ii = 0; ii < numbers1.Length; ii++)
{
    Console.WriteLine(numbers1[ii]);
}

int iiii = 0;
while (iiii < numbers.Length)
{
    Console.WriteLine(numbers[iiii]);
    iiii++;
}


int[] num11 = new int[] { 0, 1, 2, 3, 4, 5 };//одномерный массив
int[,] num22 = { { 0, 1, 2 }, { 3, 4, 5 } };//многомерный массив
//Все возможные способы определения двухмерных массивов:
int[,] numg1;
int[,] numg2 = new int[2, 3];
int[,] numg3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] numg4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] numg5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] numg6 = { { 0, 1, 2 }, { 3, 4, 5 } };

int[,] numberss = { { 1, 2, 3 }, { 44, 55, 66 } };

int rows = numberss.GetUpperBound(0) + 1;    // количество строк
int columns = numberss.Length / rows;        // количество столбцов
                                            // или так
                                            // int columns = numbers.GetUpperBound(1) + 1;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numberss[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество строк");
int nn = Convert.ToInt32(Console.ReadLine());
char[,] matrix = new char[m, nn];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = '.';
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}



Console.ReadLine();
