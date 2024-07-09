using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class TStudent
    {
        string surname; //фамилия студента
        string name; //имя студента
        char pol; //пол студента
        DateTime date; //дата рождения студента
        string town; //город проживания
        public TStudent(string surname, string name, char pol, DateTime date, string town)
        {
            this.surname = surname;
            this.name = name;
            this.pol = pol;
            this.date = date;
            this.town = town;
        }
        public char Pol()
        {
            return pol;
        }
        public int Age()
        {
            //Создаем дату, соответствующую текущей дате.
            DateTime now = DateTime.Today;
            //Вычисляем разность в годах между текущей датой и датой рождения студента.
            int age = now.Year - date.Year;
            //Отнимаем от текущей даты разность в годах.
            now = now.AddYears(-age);
            //Если дата рождения студента больше, чем текущая дата за вычетом найденной разности в годах,
            //то из найденного возраста следует вычесть 1 год, так как он полностью не закончился.
            if (date > now) age--;
            return age;
        }
        public string ShowStudent() //метод для вывода информации о студенте
        {
            string s = $"Фамилия: {surname}\n";
            s += $"Имя: {name}\n";
            s += $"Пол: {pol}\n";
            s += $"Дата рождения: {date.Day}.{date.Month}.{date.Year}\n";
            s += $"Город проживания: {town}\n";
            s += $"Возраст: {Age()}\n";
            s += "\n";
            return s;
        }
    }

}
