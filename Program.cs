
// Task1
int number = 6;
int toplama = 0;

for (int i = 1; i <= number; i++)
{
    toplama = toplama + i; //toplama += 1;
}
Console.WriteLine(toplama);


// Task2
int reqem = 5;
int factorial = 1;

for (int i = 1; i <= reqem; i++)
{
    factorial = factorial * i; //factorial *= 1;
}
Console.WriteLine(factorial);


// Task3
float eded = 30f;

while (eded > 1)
{
    eded = eded / 2; //eded /= 2; 
}
if (eded == 1)
{
    Console.WriteLine("Ikinin quvvet ustudur");
}
else 
{
    Console.WriteLine("Ikinin quvvet ustu deyil");
}