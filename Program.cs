

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


//Console.Write("Введи любое число: ");
//int x = Convert.ToInt32(Console.ReadLine());
//string xT = Convert.ToString(x);

//if (xT.Length > 2)
//{
//    Console.WriteLine("Третье число: " + xT[2]);
//}
//else 
//{
//   Console.WriteLine("Третьего числа нет");
//}


//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1



//Console.Write("Введи любое число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//string numOne = Convert.ToString(num);
//if(numOne.Length > 2)
//{
 
//      Console.WriteLine("Третья цифра: " + numOne[2]);

//}
//else
//{

//   Console.WriteLine("Третьей цифры нет");

//}



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


Console.Write("Введи номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 1 || num > 7)
{

   Console.WriteLine("Такого дня недели нет. Попробуйте еще раз.");

}
else if(num == 6 || num == 7)
 {

   Console.WriteLine("Выходной");

 }

else
{

   Console.WriteLine("Рабочий день");

}