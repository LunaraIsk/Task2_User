using System;
using System.Collections.Generic;
using System.Text;

namespace Task_User
{
    class Employee : User
    {
        public string Position { get; set; } // должность
        public int Work_experience { get; set; } // стаж работы
        public Employee(string firstName, string secondName, string lastName, 
            string birthDay, byte age, string position, int work_experience) 
            : base(firstName, secondName, lastName, birthDay, age)
        {
            Position = position;
            Work_experience = work_experience;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Стаж работы: " + Work_experience + " года/лет" + "\n" +
                "Должность: " + Position);
        }

    }
}
