using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class ArrayPractice03Library
    {
        public static void RunMyCode()
        {
            bool isOpen = true;
            string[,] books =
            {
                { "Александр Пушкин", "Михаил Лермонов", "Сергей Есенин"},
                { "Роберт Мартин", "Джесси Шелл", "Сергей Тепляков"},
                { "Стивен Кинг", "Говард Лавкрафт", "Брем Стокер"}
            };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nВесь список авторов:\n");

                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i, j] + " / ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека.");
                Console.WriteLine("\n1. Узнать имя автора по индексу книге.\n\n" +
                    "2. Найти книгу по автору.\n\n" +
                    "3. Выйти из программы.");
                Console.Write("Выберете пункт меню: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите номер столбца: ");
                        column = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"На {line} полке, в столбце {column} " +
                            $"находится писатель {books[line - 1, column - 1]}.");
                        break;
                    case 2:
                        string author;
                        bool authorIsFound = false;

                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.Write($"Автор {books[i, j]} находится по адресу: " +
                                        $"{i + 1} полка, {j + 1} место.");
                                    authorIsFound = true;
                                }
                                
                            }
                        }

                        if (authorIsFound == false)
                        {
                            Console.WriteLine("Такого автора нет.");
                        }

                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда.");
                        break;
                }

                if (isOpen)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                }

                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
