using System;
using System.Collections.Generic;
using System.Text;

namespace Task_User
{
    //Написать класс User, описывающий человека (Фамилия, Имя, Отчество, 
    //Дата рождения, Возраст). На основе класса User создать класс Employee, 
    //описывающий сотрудника фирмы. Дополнить класс свойствами "стаж работы" и 
    //"должность". Обеспечить нахождение класса в заведомо корректном состоянии.
    class User
    {
        internal string FirstName { get; set; }
        internal string SecondName { get; set; }
        internal string LastName { get; set; }
        internal string BirthDay { get; set; }
        internal byte Age { get; set; }

        public User(string firstName, string secondName, string lastName, string birthDay, byte age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
            this.Age = age;
        }
        public virtual void Show()
        {
            Console.WriteLine("ФИО: " + FirstName +" " + SecondName + " " + LastName + "\n" +
                   "Дата рождения: " + BirthDay + "\n" +
                   "Возраст: " + Age);
        }

    }
}
