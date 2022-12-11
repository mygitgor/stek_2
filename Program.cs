
// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.


int digit1 = Convert.ToInt32(Console.ReadLine());
int digit2 = Convert.ToInt32(Console.ReadLine());


if (digit1 > digit2)
{
    System.Console.WriteLine($"max= {digit1}");
    System.Console.WriteLine($"min= {digit2}");
}
else if (digit1 < digit2)
{
    System.Console.WriteLine($"max= {digit2}");
    System.Console.WriteLine($"min= {digit1}");
}
else
{
    System.Console.WriteLine("your sums are equal");
}


// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int c1 = Convert.ToInt32(Console.ReadLine());
int max;

max = 0;
if (a1 > b1 && a1 > c1)
{
    max = a1;
    Console.WriteLine("maximal chislo " + max);
}
else if (b1 > a1 && b1 > c1)
{
    max = b1;
    Console.WriteLine("maximal chislo " + max);
}
else if (c1 > a1 && c1 > b1)
{
    max = c1;
    Console.WriteLine("maximal chislo " + max);
}


// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
int numb = new Random().Next(0, 10);

for (int j = -10; j < 11; j++)
{
    System.Console.WriteLine("natural chislo:" + j);
}


// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным

int number = new Random().Next(0, 10);
for (number = 0; number <= 10; number++)
{
    if (number % 2 == 0)
        System.Console.WriteLine("cetnaya chislo:" + number);
}


//    Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


int n1 = Convert.ToInt32(Console.ReadLine());

for (int i = n1; i > 0; i--) if (i % 2 == 0)
    {
        System.Console.WriteLine(i);
    }






// Домашняя работа (не использовать для решения задач представления числа в виде строки (т.е. не брать число как массив))
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int number3 = new Random().Next(100, 999);
System.Console.WriteLine(number3);

System.Console.WriteLine($"{number3 / 10 % 10}");




// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


int number1 = new Random().Next(100, 999);
System.Console.WriteLine(number1);

System.Console.WriteLine($"{number1 / 100 * 10 + number1 % 10}");





// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.


int numberN1 = Convert.ToInt32(Console.ReadLine());
int numberN2 = Convert.ToInt32(Console.ReadLine());
int oststok = numberN1 / numberN2 % 10;
if (numberN1 % numberN2 == 0)
{
    System.Console.WriteLine("kratnoe chislo");
}
else
{
    System.Console.WriteLine("!no kratno oststok:" + oststok);
}




//   Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



System.Console.WriteLine("naberite tri chislo_");
int myNumber = Convert.ToInt32(Console.ReadLine());
double n = myNumber % 10;
if (myNumber > 99)
{
    System.Console.WriteLine("tretyaya cifra " + n);
}
else if (myNumber < 99)
{
    System.Console.WriteLine("! nabrali menshe chislo " + myNumber);
}




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.



System.Console.WriteLine("naberite  den nedeli_");
int mynuUber = Convert.ToInt32(Console.ReadLine());
if (mynuUber < 7 && mynuUber > 0)
{
    System.Console.WriteLine("working day");
}
else if (mynuUber > 5 && mynuUber < 8)
{
    System.Console.WriteLine("vixodnoy day");
}
else if (mynuUber < 1 || mynuUber > 7)
{
    System.Console.WriteLine("!!!ne den nedeli");
}




// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.



int chislo = Convert.ToInt32(Console.ReadLine());

if (chislo % 7 == 0 && chislo % 23 == 0)
{
    System.Console.WriteLine("kratnoe chislo");
}
else
{
    System.Console.WriteLine("!!! ne kratno");
}



// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = a * a;
if (b == c) Console.WriteLine("a kvadrat b");
else if (b != c) Console.WriteLine("a !=no kvadrat b");


