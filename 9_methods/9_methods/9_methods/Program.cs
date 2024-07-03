//0saDDev1 03.07.2024

//Методы
//метод - это именованный блок кода, который выполняет некоторые действия
/*
[модификаторы] тип_возвращаемого_значения название_метода ([параметры])
{
    // тело метода
}
*/

void SayHello()
{
    Console.WriteLine("Hello");
}
SayHello();

void SayHelloRu()
{
    Console.WriteLine("Привет");
}
void SayHelloEn()
{
    Console.WriteLine("Hello");
}
void SayHelloFr()
{
    Console.WriteLine("Salut");
}

Console.WriteLine("Select lang en/ru/fr:");
string language = Convert.ToString(Console.ReadLine());

switch (language)
{
    case "en":
        SayHelloEn();
        break;
    case "ru":
        SayHelloRu();
        break;
    case "fr":
        SayHelloFr();
        break;
}


//так же есть сокращенная запись методов
//	void SayHello() => Console.WriteLine("Hello");


Console.ReadLine();