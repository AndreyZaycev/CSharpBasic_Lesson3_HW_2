using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HomeWork_2
{
    internal class Program
    {
        //формирование данных телефонного справочника
        static string[,] GetData()
        {
            //матрица данных
            string[,] mtxPhoneDirectory = new string[5, 2];

            //Заполнение первого столбца - Ф.И.О. контакта
            mtxPhoneDirectory[0, 0] = "Авдеев А. А.";
            mtxPhoneDirectory[1, 0] = "Бестужев К. К.";
            mtxPhoneDirectory[2, 0] = "Василевский Д. Д.";
            mtxPhoneDirectory[3, 0] = "Иванов И. И.";
            mtxPhoneDirectory[4, 0] = "Петров П. П.";

            //Заполнение второго столбца - телефон/e-mail
            mtxPhoneDirectory[0, 1] = "8-920-155-34-56";
            mtxPhoneDirectory[1, 1] = "8-930-155-78-99";
            mtxPhoneDirectory[2, 1] = "vasil_dd@mail.ru";
            mtxPhoneDirectory[3, 1] = "ivanov_ii@yandex.ru"; ;
            mtxPhoneDirectory[4, 1] = "8-950-459-41-72";

            //
            return mtxPhoneDirectory;
        }

        //вывод данных
        static void PrintData(string[,] mtxData)
        {
            //строка составного формата: "{0,-20} | {1,-20}" 
            //  = выравнивает Ф.И.О. контакта по левому краю 20-символьного поля
            //  = выравнивает Телефон/E-mail по левому краю 20-символьного поля
            Console.WriteLine("{0,-20} | {1,-20}", "Ф.И.О. контакта", "Телефон/E-mail");
            for (int i = 0; i < mtxData.GetLength(0); i++)
                Console.WriteLine("{0,-20} | {1,-20}", mtxData[i, 0], mtxData[i, 1]);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Урок 3, домашнее задание № 2");

            //получение данных телефонного справочника
            string[,] mtxPhoneDirectory = GetData();

            //вывод данных на консоль
            PrintData(mtxPhoneDirectory);

            //
            Console.ReadLine();
        }
    }
}
