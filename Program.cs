
// Домашняя работа (не использовать для решения задач представления числа в виде строки (т.е. не брать число как массив))
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int number = new Random().Next(100, 999);
System.Console.WriteLine(number);

System.Console.WriteLine($"{number/10%10}");




// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


int number1 = new Random().Next(100, 999);
System.Console.WriteLine(number1);

System.Console.WriteLine($"{number1/100*10 + number1 %10}");





// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.


  int numberN1 = Convert.ToInt32(Console.ReadLine());
  int numberN2 = Convert.ToInt32(Console.ReadLine());
  int oststok = numberN1/numberN2 %10; 
  if (numberN1 % numberN2 == 0)
  {
     System.Console.WriteLine("kratnoe chislo");
  }
  else
  {
    System.Console.WriteLine("!no kratno oststok:"+ oststok);
  }




//   Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



 System.Console.WriteLine("naberite tri chislo_");
int myNumber = Convert.ToInt32(Console.ReadLine());
double n = myNumber%10;
if(myNumber > 99) 
{ 
    System.Console.WriteLine("tretyaya cifra "+n);
}
else if(myNumber < 99){
    System.Console.WriteLine("! nabrali menshe chislo "+myNumber);
}




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.



System.Console.WriteLine("naberite  den nedeli_");
int mynuUber = Convert.ToInt32(Console.ReadLine());
if (mynuUber < 7 &&  mynuUber > 0)
{
   System.Console.WriteLine("working day");
}
else if(mynuUber > 5 && mynuUber < 8){
    System.Console.WriteLine("vixodnoy day");
}
else if(mynuUber < 1 || mynuUber > 7)
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


