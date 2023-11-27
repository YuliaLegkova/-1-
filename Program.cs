// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Добро пожаловать, введите команду: \\start; \\help; \\info; \\exit");
string command = "";
do
{
    command = Console.ReadLine();
    switch (command)
    {
        case @"\start":
            string commandstart = "";
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + ", теперь вам доступна команда \\echo с аргументом, вводимым через пробел");

            do
            {
                string x = Console.ReadLine();
                string[] arr = x.Split();
                commandstart = arr[0];
                               
                   switch (commandstart)
                    {
                        case @"\echo":
                        if (arr.Length > 1)
                            Console.WriteLine(arr[1]);
                        else
                            Console.WriteLine(name + ", вы не ввели аргумент");
                                break;
                              case @"\help":
                            Console.WriteLine(name + ", программа выполняет команды:\\start; \\help; \\info; \\exit;" + "\n" + "для начала работы введите:\\start;" + "\n" + "для получения справки введите: \\help;" + "\n" + "для получения информации о версии программы введите:\\info;" + "\n" + "для выхода из программы введите:\\exit;" + "\n" + "для получения эхо введите команду: \\echo с аргументом, вводимым через пробел" + "\n" + "импользуйте команды из указанного перечня");
                            break;
                        case @"\info":
                            Console.WriteLine(name + ", Версия 3 от 27.11.2023");
                            break;
                        case @"\exit":
                            break;
                        default:
                            Console.WriteLine(name + ", такой команды нет");
                            break;

                    }
             }
            while (commandstart != @"\exit");
            Console.Write(name + ", ");
            goto End;
           
        case @"\help":
            Console.WriteLine("программа выполняет команды:\\start; \\help; \\info; \\exit;" + "\n" + "для начала работы введите:\\start;" + "\n" + "для получения справки введите: \\help;" + "\n" + "для получения информации о версии программы введите:\\info;" + "\n" + "для выхода из программы введите:\\exit;" + "\n" + "используйте команды из указанного перечня");
            break;
        case @"\info":
            Console.WriteLine("Версия 3 от 27.11.2023");
            break;
        case @"\exit":
            break;
        default:
            Console.WriteLine("Такой команды нет");
            break;

    }

} while (command != @"\exit");

End:
Console.Write("До новых встреч");




