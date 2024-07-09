
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _2._1.model
{

    class TGroup
    {

        string nameGroup;
        int numStudents;
        int mesto;
        int a;
        //Коллекция
        List<TStudent> students;
        public TGroup()
        {
            try
            {
                Console.Write("наименование направления: ");
                nameGroup = Console.ReadLine();
                int aaaa = 0;
                while (aaaa == 0)
                {
                    try
                    {
                        Console.Write("количество абитуриентов, подавших документы: ");
                        numStudents = int.Parse(Console.ReadLine());
                        aaaa = 1;
                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("Ошибка формата данных");
                    }
                    catch (Exception ) { Console.WriteLine("какая-то ошибка"); }
                }
                aaaa = 0;
                while (aaaa == 0)
                {
                    try
                    {
                        Console.Write("количество мест для приема: ");
                        mesto = int.Parse(Console.ReadLine());
                        aaaa = 1;
                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("Ошибка формата данных");
                    }
                    catch (Exception ) { Console.WriteLine("какая-то ошибка"); }
                }

                students = new List<TStudent>();
                Console.WriteLine();
                //если мест для поступления больше
                if (mesto > numStudents) { a = 0; }
                //для списка не поступивших
                else { a = numStudents - mesto; }
                for (int i = 0; i < numStudents; i++)
                {
                    students.Add(new TStudent());
                }
                //СОРТИРОВКА ПО БАЛЛАМ
                students = students.OrderByDescending(s => s.sumbalov).ToList();
            }
            catch { Console.WriteLine("Критическая Ошибка пожалуйста не заходите больше в программу"); throw new Exception(); };
        }
        public string ShowGroup()
        {
            string txt;
            txt=$"Список студентов группы: {nameGroup}\n";
            for (int i = 0; i < students.Count - a; i++)
            {
                txt=txt+students[i].ShowStudent();
                
            }
            txt = txt + "список абитуриентов, не поступивших на данное направление:";
            for (int i = mesto; i < students.Count; i++)
            {
                txt = txt + students[i].ShowStudent();
                
            }
            return txt;
        }
    }
}
