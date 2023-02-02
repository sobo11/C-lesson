// //вид 1
// void Method1()
// {
//     Console.WriteLine("1");
// }
// Method1(); //вызывает метод

// //вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("текст");



// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg:"q",count:6);


// // вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);




// //вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; //String.Empty - пустая строка
//     while(i<count)
//     {
//         result = result + text;
//         i ++;
//     }
//     return result;
// }

// string res = Method4(10, "rty");
// Console.WriteLine(res);

//через for

string Method4(int count, string text)
{
    string result = String.Empty; //String.Empty - пустая строка
    for (int i = 0; i < count; i ++)
    {
        result = result + text;
    }
        
    return result;
}

string res = Method4(10, "p");
Console.WriteLine(res);



for (int i = 2; i <= 10; i ++)
{
    for (int j = 2; j <= 10; j ++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}





string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+"ежели бы вас послали вместо нашего милого Винценгероде,"
+"вы бы взяли приступом согласие прусского короля."
+"Вы так красноречивы. Вы дадите мне чаю?";


//