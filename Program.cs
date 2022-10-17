// See https://aka.ms/new-console-template for more information
// Придумать класс, описывающий студента. Предусмотреть в нем 
// следующие моменты :
// фамилия, имя, отчество, группа, возраст
// массив (зубчатый) оценок по:
// программированию, администрированию, дизайну
// Предусмотреть конструктор. Также добавить методы
// по работе с перечисленными данными:
// возможность установки\получения оценок,
// получение среднего балла по заданному предмету,
// распечатка данных о студенте

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        Console.Title = "c#"; // оформление
        Console.BackgroundColor = ConsoleColor.Black; //изменяет цвет фона
        Console.ForegroundColor = ConsoleColor.DarkGreen;//изменяет цвет текста
        Console.SetWindowSize(100, 30);//устанавливаем размер окна консоли
        Student st = new Student();
        st.Show();
        Console.WriteLine("Вывод типа данных: " + st.GetType());
        Console.WriteLine("Вывод случайной оценки: ");
        Student ula = new Student();
        ula.Show();
        ula.GetMark();
        ula.Show();


    }
}

class Student // создаем класс студент
{
    private string _surname;//фамилия
    private string _name;//имя
    private string _patronymic;//отчество
    private string _group;//группа
    private int _age;// возраст
    private int [][] _estimation = new int [3][];//оценка


    public Student() // конструктор по умолчанию заполнение обьекта
    {
        _surname = "Ulia";
        _name = "Loving";
        _patronymic = "tigress";
        _group = "Students";
        _age = 16;
        Console.WriteLine("\nработает конструктор по умолчанию заполнение обьекта\n");
    }
    public Student(string surname, string name, string patronymic,
        string group, int age)// конструктор с параметрами
    {
        this._surname = surname;        //  поле фамилия
        this._name = name;              // поле имя
        this._patronymic = patronymic;  // поле отчество
        this._group = group;            // поле группа
        this._age = age;                // поле возраст
        Console.WriteLine("\nработает конструктор с параметрами\n");
    }
    public void GetMark()// возможность получения оценок
    {
        Console.WriteLine("Введите кол-во оценок\t");
        int mass1 = int.Parse(Console.ReadLine());
        _estimation[0]=new int[mass1];
        for (int i = 0; i < _estimation[0].Length; i++)
        {
            _estimation[0][i] = int.Parse(Console.ReadLine());
        }
        _estimation[1] = new int[mass1];
        for (int i = 0; i < _estimation[1].Length; i++)
        {
            _estimation[1][i] = int.Parse(Console.ReadLine());
        }
        _estimation[2] = new int[mass1];
        for (int i = 0; i < _estimation[2].Length; i++)
        {
            _estimation[2][i] = int.Parse(Console.ReadLine());
        }
    }
    public static void SetMark(string setM)// возможность установки оценок
    {
        Console.WriteLine("Ввод оценки: ");
        Console.WriteLine("***********************************");
        //setM = int.Parse(setM);
        //_estimation =  setM;
    }
    public void Show() // Метод для вывода информации
    {
        Console.WriteLine("ФИО : {0}", _surname + " " + _name + " " + _patronymic);
        Console.WriteLine("Группа: {0}", _group);
        Console.WriteLine("возраст :{0}", _age);
        Console.WriteLine("оценка : {0}", _estimation);
    }
}
