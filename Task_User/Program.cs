using System;
using System.IO;
namespace Task_User
{
    class Program
    {
        static public User[] Input() //читаем данные из файла
        {
            using (StreamReader fileIn = new StreamReader("input.txt"))
            {
                int n = int.Parse(fileIn.ReadLine());
                User[] ar = new User[n];
                for (int i = 0; i < n; i++)
                {
                    string[] text = fileIn.ReadLine().Split(' ');
                    if (text.Length == 5)
                    {
                        ar[i] = new User(text[0], text[1], text[2], text[3], byte.Parse(text[4]));
                    }
                    else
                    {
                        if (text.Length == 7)
                        {
                            ar[i] = new Employee(text[0], text[1], text[2], text[3], byte.Parse(text[4]), text[5], int.Parse(text[6]));
                        }
                        else
                        {
                            Console.WriteLine("Неверное количество аргументов");
                        }
                    }
                }
                return ar;
            }
        }
        static void Print(User[] array) //выводим данные 
        {
            foreach (User item in array)
            {
                item.Show();
            }

        }
        static void Main(string[] args)
        {

            User[] array = Input();
            Print(array);
            Console.ReadKey();
           
        }
    }
}
