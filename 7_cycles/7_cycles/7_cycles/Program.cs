//0saDDev1 28.06.2024

//ЦИКЛЫ

//Цикл for
Console.WriteLine($"Цикл for");
/*
 * for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
{
    // действия
}
*/
for (int i = 1; i < 4; i++)
{
    Console.WriteLine(i);
}
//Если блок цикла for содержит одну инструкцию, то мы можем его сократить, убрав фигурные свобки:
for (int a = 1; a < 4; a++)
    Console.WriteLine(a);
// или так
for (int b = 1; b < 4; b++) Console.WriteLine(b);
//такой вариант тоже корректен
var c = 1;
for (Console.WriteLine("Начало выполнения цикла"); c < 4; Console.WriteLine($"c = {c}"))
{
    c++;
}
//можно объявлять несколько переменных в цикле:
for (int ii = 1, jj = 1; ii < 10; ii++, jj++)
    Console.WriteLine($"{ii * jj}");
//бесконечных циклов стоит избегать!!!
/*
int i = 1;
for (; ;)
{
    Console.WriteLine($"i = {i}");
    i++;
}
*/
Console.WriteLine();

//Цикл do..while
Console.WriteLine($"Цикл do..while");
/*
do
{
    действия цикла
}
while (условие)
*/
int q = 6;
do
{
    Console.WriteLine(q);
    q--;
}
while (q > 0);

int qq = -1;
do
{
    Console.WriteLine(qq);
    qq--;
}
while (qq > 0);
//один раз цикл всёравно выполнится
Console.WriteLine();

//Цикл while
Console.WriteLine($"Цикл while");
/*
while (условие)
{
    действия цикла
}
 */
int w = 6;
while (w > 0)
{
    Console.WriteLine(w);
    w--;
}
Console.WriteLine();

//Цикл foreach
Console.WriteLine($"Цикл foreach");
/*
foreach(тип_данных переменная in коллекция)
{
    // действия цикла
}
*/
foreach (char ch in "Tom")
{
    Console.WriteLine(ch);
}
Console.WriteLine();

//Операторы continue и break
Console.WriteLine($"Операторы continue и break");
//Иногда возникает ситуация, когда требуется выйти из цикла, не дожидаясь его завершения. В этом случае мы можем воспользоваться оператором break.
for (int m = 0; m < 9; m++)
{
    if (m == 5)
        break;
    Console.WriteLine(m);
}
//если мы хотим, чтобы при проверке цикл не завершался, а просто пропускал текущую итерацию. Для этого мы можем воспользоваться оператором continue
for (int m1 = 0; m1 < 9; m1++)
{
    if (m1 == 5)
        continue;
    Console.WriteLine(m1);
}
Console.WriteLine();

//Вложенные циклы
Console.WriteLine($"Вложенные циклы");
for (int abc = 1; abc < 10; abc++)
{
    for (int jj = 1; jj < 10; jj++)
    {
        Console.Write($"{abc * jj} \t");
    }
    Console.WriteLine();
}
//такие констрцкции сильно нагружают вычеслительные мощности их стоит избегать


Console.ReadLine();
