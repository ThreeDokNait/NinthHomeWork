Console.Clear();

// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Enter number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 1)
// {
//     int finNum = 1;
//     string PrintNumber(int start, int fin)
//     {
//         if (start == fin)
//         {
//             return start.ToString();
//         }
//         return (start + " " + PrintNumber(start - 1, fin));
//     }
//     Console.WriteLine(PrintNumber(num, finNum));
// }
// else
// {
//     System.Console.WriteLine("enter a number greater than 1");
// }

// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// System.Console.WriteLine("Enter number M"); 
// int num1 = Convert.ToInt32(System.Console.ReadLine()); 

// System.Console.WriteLine("Enter number N"); 
// int num2 = Convert.ToInt32(System.Console.ReadLine()); 

// if (num1 < num2) 
// {     
//     Console.WriteLine(PrintNum(num1,num2)); 
// } 
// else 
// {     
//     System.Console.WriteLine("Enter number N greater then M"); 
// } 

// int PrintNum(int start, int end) 

// {     
//     if (start == end)     
//     {         
//         return start;     
//     }     
//     return(start + PrintNum(start+1, end)); 
// }



// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



// Console.WriteLine("Enter number m"); 
// int num = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Enter number n"); 
// int num2 = Convert.ToInt32(Console.ReadLine()); 

// int Akker(int m, int n) 
// {   
//     if(m==0)   
//     {     
//         return n+1;   
//     }   
//     if(n==0)   
//     {     
//         return Akker(m-1,1);   
//     }   
//     return Akker(m-1,Akker(m,n-1)); 
// } 
// Console.WriteLine(Akker(num,num2));