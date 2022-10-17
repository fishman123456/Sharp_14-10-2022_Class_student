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
      
       // Console.WriteLine("Вывод типа данных: " + st.GetType());
       // Console.WriteLine("Вывод случайной оценки: ");
        Student ula = new Student();
        ula.SetMar();
        ula.Show();
        ula.GetMark();
        st.Show();
        ula.aver();

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
    private double _average_end; // средняя оценка

    public Student() // конструктор по умолчанию заполнение обьекта
    {
        _surname = "Ulia";
        _name = "Loving";
        _patronymic = "tigress";
        _group = "Students";
        _age = 16;
        _average_end = 9.2;
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
    public void SetMar ()//  возможность установки оценок
    {
        Console.WriteLine("Введите кол-во оценок\t");
        int mass1 = int.Parse(Console.ReadLine()); // преобразуем строку в число
        _estimation[0]=new int[mass1];  // выделяем память
        Console.WriteLine("Оценки по программированию\t");
        for (int i = 0; i < _estimation[0].Length; i++) // заполняем массив нулевой
        {
            _estimation[0][i] = int.Parse(Console.ReadLine()); // заносим переменные в массив
        }
        _estimation[1] = new int[mass1];
        Console.WriteLine("Оценки по администрированию\t");
        for (int i = 0; i < _estimation[1].Length; i++)
        {
            _estimation[1][i] = int.Parse(Console.ReadLine());
        }
        _estimation[2] = new int[mass1];
        Console.WriteLine("Оценки по дизайну\t");
        for (int i = 0; i < _estimation[2].Length; i++)
        {
            _estimation[2][i] = int.Parse(Console.ReadLine());
        }
    }
    public  void GetMark()// возможность получения оценок и вывод на экран
    {
        Console.WriteLine("***********************************");
        Console.WriteLine("Ввод оценки: ");

        for (int i = 0; i < _estimation[0].Length; i++) 
        {
           Console.WriteLine("Оценки по программированию\t" + _estimation[0][i]) ; // вывод переменных из массива

        }
        
        for (int i = 0; i < _estimation[1].Length; i++)
        {
            Console.WriteLine("Оценки по администрированию\t" + _estimation[1][i]); // вывод переменных из массива
        }
       
        for (int i = 0; i < _estimation[2].Length; i++)
        {
            Console.WriteLine("Оценки по дизайну\t" + _estimation[2][i]); // вывод переменных из массива
        }
        //setM = int.Parse(setM);
        //_estimation =  setM;
    }
    public void aver()
    {
        double average0 = _estimation[0].Average();
        double average1 = _estimation[1].Average();
        double average2 = _estimation[2].Average();
        _average_end = ((average0 + average1 + average2) / 3);
        Console.WriteLine("Средняя оценка по 3 предметам\t" + _average_end);
        
    }
    public void Show() // Метод для вывода информации
    {
       
        Console.WriteLine("ФИО : {0}", _surname + " " + _name + " " + _patronymic);
        Console.WriteLine("Группа: {0}", _group);
        Console.WriteLine("возраст :{0}", _age);
        Console.WriteLine("оценка : {0}", 0);
    }
}
