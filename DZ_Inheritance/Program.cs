using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Kitchen
{
    public abstract class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public Human(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

        

        public override string ToString()
        {
            return $"Имя: {_firstName}\nФамилия: {_lastName}\nДата рождения: {_birthDate}";
        }
       
    }

    abstract class Employee : Human
    {
        string _restaurant;

        public Employee(string firstName, string lastName, DateTime birthDate, string restaurant) : base(firstName, lastName, birthDate)
        {
            _restaurant = restaurant;
        }
        public abstract void Think();
        public abstract void Study();

        public override string ToString()
        {
            return base.ToString() + $"\nРесторан: {_restaurant}";
        }

    }

    class Cook : Employee
    {
        string _workshop;

        public Cook(string firstName, string lastName, DateTime birthDate, string restaurant, string workshop) : base(firstName, lastName, birthDate, restaurant)
        {
            _workshop = workshop;
        }

        public override void Think()
        {
            WriteLine("Я думаю, что я лучший повар");
        }

        public override void Study()
        {
            WriteLine("Я готовлю много разных блюд\n");
        }


        public override string ToString()
        {
            return base.ToString() + $"\nЯ работаю в {_workshop} цеху";
        }
    
    }

    class Waiter : Employee
    {
        string _hallName;

        public Waiter(string firstName, string lastName, DateTime birthDate, string restaurant, string hallName) : base(firstName, lastName, birthDate, restaurant)
        {
            _hallName = hallName;
        }

        public override void Think()
        {
            WriteLine("Я думаю, что я хороший официант");
        }

        public override void Study()
        {
            WriteLine("Я обслуживаю много клиентов\n");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nЯ обслуживаю клиентов в {_hallName} зале";
        }
    }

    class Barman : Employee
    {
        string _drinkName;

        public Barman(string firstName, string lastName, DateTime birthDate, string restaurant, string drinkName) : base(firstName, lastName, birthDate, restaurant)
        {
            _drinkName = drinkName;
        }

        public override void Think()
        {
            WriteLine("Я думаю, что я бармен");
        }

        public override void Study()
        {
            WriteLine("Я умею делать разные коктейли\n");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nЯ работаю в отделе {_drinkName} напитки";
        }
    }

    class Kitchen
    {
        static void Main(string[] args)
        {
            Employee[] Employes =
            {
                new Cook("Максим", "Лавров", new DateTime(1984, 12,22), "Claude Monet", "заготовительном"),
                new Cook("Лев", "Соловьев", new DateTime(1979, 07,2), "Victor", "доготовочном"),
                new Cook("Louis", "Benoit", new DateTime(1979, 12,3), "Victor", "кондитерском"),
                new Waiter("Настя", "Фомина", new DateTime(1987, 06,16), "Claude Monet", "красном"),
                new Waiter("Саша", "Бубнова", new DateTime(1987, 07,12), "Claude Monet", "желтом"),
                new Barman("Костя", "Анисимов", new DateTime(1990, 03,22), "Victor", "спиртные"),
            };
            foreach (Employee item in Employes)
            {
                WriteLine(item);
                item.Think();
                item.Study();
            }
        }
    }
}

