/*ЗЗадача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.*/
/*
Console.WriteLine("Input first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
 {
    Console.WriteLine("First number " + num_1 + " more than second " + num_2);
 }
else
 {
 Console.WriteLine("Second number " + num_2 + " more than first number " + num_1);
 }
*/

// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Imput number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
 {
   max = num2;
 }

if (num3 > max)
 {
   max = num3;
 }

Console.WriteLine("The max number is  " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num = num * (-1);
}
 
if (num % 2 == 0)
 {
    Console.WriteLine("Number is even");
 }
  else
 {
    Console.WriteLine("Number  is odd");
 }



// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


/*Console.WriteLine("Input number : ");
int num = Convert.ToInt32(Console.ReadLine());

int current_i = 1;

while(current_i <= num)
{
    if (current_i%2 == 0)

     Console.WriteLine(current_i +", ");

    current_i++;
}
*/