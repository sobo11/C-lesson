﻿//вид 1
void Method1()
{
    Console.WriteLine("1");
}
Method1(); //вызывает метод

//вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("текст");



void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg:"q",count:6);


