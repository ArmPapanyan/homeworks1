//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if ( num1 > num2) 
//  {
// Console.WriteLine($"Firts number is maximal  and Second number is minimal");

// }

// if(num1 < num2)

// {
//  Console.WriteLine($"Second number is maximal and First number is minimal ");

// }

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input third number");
// int num3 = Convert.ToInt32(Console.ReadLine());

//if(num1 > num2 )
// if(num1 > num3 )
//{
//  Console.WriteLine($"maximal is {num1}");
// }
// if(num2>num1)
// if(num2>num3)
// {
// Console.WriteLine($"maximal is {num2}");
//}
//if(num3 > num1)
//if(num3 > num2)
// {
// Console.WriteLine($"maximal is {num3}");
//}


//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//Console.WriteLine ("Input number");
//int n = Convert .ToInt32 (Console.ReadLine());
//if(n%2==0)

//{
// Console.WriteLine ("You input even number");
//}
//else
//{
// Console.WriteLine ("You input not even number");
//}

//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;


while (current <= n)
{
    if (current % 2 == 0)
        Console.Write(current + " ");
    current++;
}





