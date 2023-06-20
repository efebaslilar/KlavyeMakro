using System;
using System.Threading;
using WindowsInput;

InputSimulator inputSimulator = new InputSimulator();
string replyText = "";
int replyTime;


Console.WriteLine("Tekrar edilecek metini girin:");
replyText = Console.ReadLine();

if (string.IsNullOrEmpty(replyText))
{
    Environment.Exit(0);
}

Console.WriteLine("Kaç ms'de bir tekrar etmesi gerektiğini girin:");
if (Int32.TryParse(Console.ReadLine(), out replyTime))
{
    while (true)
    {
        KeyboardPress();
        Thread.Sleep(replyTime);
    }
}
else
{
    Console.WriteLine("Lütfen sadece sayı giriniz!!");
}


 void KeyboardPress()
{
    inputSimulator.Keyboard.TextEntry(replyText);
}

