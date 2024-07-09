using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2._1.model
{
    class TStudent
    {
        string surname { get; set; }
        string name { get; set; }
        char pol { get; set; }
        DateTime date { get; set; }
        int EGEmath { get; set; }
        int EGEru { get; set; }
        int EGEinf { get; set; }
        //СУММА БАЛЛОВ
        public int sumbalov { get; set; }


        public TStudent()
        {
            bool k = false;
            
            try
            {
                while (k == false)
                {
                    try
                    {
                        Console.Write("Введите фамилию: "); surname = Console.ReadLine();
                        k = Regex.IsMatch(surname, @"^[a-zA-Zа-яА-Я]+$");
                        if (k == false) { throw new Exception(); }
                    }
                    catch (Exception) { Console.WriteLine("Ошибка Ввода "); }
                    
                }
                k = false;
                while (k == false)
                {
                    try
                    {
                        Console.Write("Введите имя: "); name = Console.ReadLine();
                        k = Regex.IsMatch(name, @"^[a-zA-Zа-яА-Я]+$");
                        if (k == false) { throw new Exception(); }
                    }
                    catch (Exception) { Console.WriteLine("Ощибка Ввода");}
                    
                }
                k = false;
                while (k == false)
                {
                    try
                    {
                        Console.Write("Введите пол(M/Ж): "); pol = char.Parse(Console.ReadLine());
                        if (pol != 'М' & pol != 'Ж') { throw new Exception(); }
                        k = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка формата данных");
                    }
                    catch (Exception) { Console.WriteLine("Ошибка Ввода. Вводить можно только M или Ж "); }
                }
                int nn = 0;
                int yearBirthday = 0;
                int dayBirthday = 0;
                int mountBirthday = 0;
                while (nn == 0)
                {
                    try
                    {
                        Console.WriteLine("Введите день,месяц и год рождения: ");

                        k = false;
                        while (k == false)
                        {
                            try
                            {
                                Console.Write("день:");
                                dayBirthday = int.Parse(Console.ReadLine());
                                if (dayBirthday < 1 | dayBirthday > 31) { throw new Exception(); }
                                k = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Ошибка формата данных");
                            }
                            catch (Exception) { Console.WriteLine("Ошибка  день  число от 1 до 31 "); }
                        }

                        k = false;
                        while (k == false)
                        {
                            try
                            {
                                Console.Write("номер месяцa: ");
                                mountBirthday = int.Parse(Console.ReadLine());
                                if (mountBirthday < 1 | mountBirthday > 12) { throw new Exception(); }
                                k = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Ошибка формата данных");
                            }
                            catch (Exception) { Console.WriteLine("Ошибка  день  месяц от 1 до 12 "); }
                        }
                        k = false;
                        while (k == false)
                        {
                            try
                            {
                                DateTime вф = DateTime.Today;
                                Console.Write("год: ");
                                int agee = вф.Year - 17;
                                yearBirthday = int.Parse(Console.ReadLine());
                                if (yearBirthday < 1950 | yearBirthday > agee) { throw new Exception(); }
                                k = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Ошибка формата данных");
                            }
                            catch (Exception) { Console.WriteLine($"Ошибка  день  месяц от 1950 до 2007  "); }
                        }

                        date = new DateTime(yearBirthday, mountBirthday, dayBirthday);
                        nn++;
                    }
                    catch { Console.WriteLine("Ошибка неправельное количество дней в месяце" + "\n введите дату заново "); }
                }
                k = false;
                while (k == false)
                {
                    try
                    {
                        Console.Write("Введите результат ЕГЭ по математике: "); EGEmath = int.Parse(Console.ReadLine());
                        if (EGEmath < 0 | EGEmath > 100) { throw new Exception(); }
                        k = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка формата данных");
                    }
                    catch (Exception) { Console.WriteLine("Ошибка баллы от 0-100 "); }
                }
                k = false;
                while (k == false)
                {
                    try
                    {
                        Console.Write("Введите результат ЕГЭ по русскому языку: "); EGEru = int.Parse(Console.ReadLine());
                        if (EGEru < 0 | EGEru > 100) { throw new Exception(); }
                        k = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка формата данных");
                    }
                    catch (Exception) { Console.WriteLine("Ошибка баллы от 0-100 "); }
                }
                k = false;
                while (k == false)
                {
                    try
                    {
                        Console.Write("Введите результат ЕГЭ по информатике: "); EGEinf = int.Parse(Console.ReadLine());
                        if (EGEinf < 0 | EGEinf > 100) { throw new Exception(); }
                        k = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка формата данных");
                    }
                    catch (Exception) { Console.WriteLine("Ошибка баллы от 0-100 "); }
                }
                //СЧИТАЕМ СУММУ БАЛОВ
                sumbalov = EGEmath + EGEru + EGEinf;
                Console.WriteLine();
            }
            catch (Exception)
            { throw new Exception(); }
        }

        int Age()
        {

            DateTime now = DateTime.Today;
            int age = now.Year - date.Year;
            now = now.AddYears(-age);
            if (date > now) age--;
            return age;
        }
        public string ShowStudent()
        {
            string text;
            text = $"\nФамилия: {surname}\n";
            text = text + $"Имя: {name}\n";
            text = text + $"Пол: {pol}\n";
            text = text + $"Дата рождения: {date.Day}.{date.Month}.{date.Year}\n";
            text = text + $"Возраст: {Age()}\n";
            text = text + $"ЕГЭ по математике: {EGEmath}\n";
            text = text + $"ЕГЭ по русскому языку: {EGEru}\n";
            text = text + $"ЕГЭ по информатике: {EGEinf}\n";
            //выводим сумму балов
            text = text + $"Сумма балов={sumbalov}\n";
            return text;
        }

    }

}
