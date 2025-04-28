//a)Verilmiş ədədin 3-ə bölünüb bölünmədiyini tapan alqoritm

#region task a

int a = Convert.ToInt32(Console.ReadLine());

if(a == 0)
{
    Console.WriteLine("You cannot select zero");
}
else if(a % 3 == 0)
{
    Console.WriteLine("Your number is divisible by 3");
}
else
{
    Console.WriteLine("Your number is not divisble by 3");
}

#endregion

#region task b
//b)Verilmiş ədədin 10-dan böyük və 15-dən kiçik olub olmadığını

int b = Convert.ToInt32(Console.ReadLine());

if(b > 10 && b < 15)
{
    Console.WriteLine("Your number is greater than 10 and less than 15");
}
else
{
    Console.WriteLine("Your number is not between 10 and 15.");
}

#endregion

#region task c
//  c)Verilmiş n ədədinin 3-ə və 7-ə bölünüb bölünmədiyini tapan alqoritm qurun

int c = Convert.ToInt32(Console.ReadLine());

if(c == 0)
{
    Console.WriteLine("You cannot select 0");
}
else if (c % 21 == 0)
{
    Console.WriteLine("Your number is divisible by 3 and 7");
}
else
{
    Console.WriteLine("Your number is not divisible by 3 and 7");
}

#endregion