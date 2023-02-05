// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Task 19");
Console.WriteLine("Enter numbers :");
string strNumber = Console.ReadLine();
int number = 0;
   
if (int.TryParse(strNumber, out number))
{
    if (number > 9999 && number < 100000)
    {
        int number1 = number%10;
        int number2 = (number/10)%10;
            
        if (number >= 10)
            {
                while (number > 99)
                {
                    number = number / 10;
                }
            }
        int number3 = number % 10;
        int number4 =  number / 10;
        
        if (number1==number4 && number2==number3)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
        }    
        else
        {
            Console.WriteLine("введите пятизначное число");
        }
           
}

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Enter number X1:");
int numX1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number Y1:");
int numY1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number Z1:");
int numZ1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number X2:");
int numX2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number Y2:");
int numY2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number Z2:");
int numZ2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(((numX1-numX2)*(numX1-numX2))+((numY1-numY2)*(numY1-numY2))+((numZ1-numZ2)*(numZ1-numZ2)));

Console.WriteLine(result);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Task 23");
Console.WriteLine ("Enter numbers :");
string strNumberN = Console.ReadLine();
int numberN = 0;

if (int.TryParse (strNumberN, out numberN))
{
    

    int num = 1;
    int num3 = 0;

    if (numberN<=1)
    { 
        Console.WriteLine("введите число больше 1");
    }
    else
    {
        while (num<=numberN)
        {
            num3 = num*num*num;
            num = num + 1;
            Console.Write(num3+" ");
        }
    }
}