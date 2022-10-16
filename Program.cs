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

using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;

Console.Title = "Класс студент"; // оформление
Console.BackgroundColor = ConsoleColor.Black; //изменяет цвет фона
Console.ForegroundColor = ConsoleColor.DarkGreen;//изменяет цвет текста
Console.SetWindowSize(100, 30);//устанавливаем размер окна консоли

class Program
{
    static void Main()
    {
        Student st = new Student();

    }
}
class Student // создаем класс студент
{
   public string _surname;//фамилия
   public string _name;//имя
   public int _patronymic;//отчество
   public string _group;//группа
   public int _age;// возраст
   public double _estimation;//оценка
    //public Student(string surname, string name, int patronymic,
    //    string group, int age, double estimation)
    //{
    //    _surname = surname;
    //    _name = name;
    //    _patronymic = patronymic;
    //    _group = group;
    //    _age = age;
    //    _estimation = estimation;
    //}

    public Student(string surname, string name, int patronymic,
        string group, int age, double estimation)
    {
        this._surname = surname;
        this._name = name;
        this._patronymic = patronymic;
        this._group = group;
        this._age = age;
        this._estimation = estimation;
        Console.WriteLine("\nработает конструктор с параметрами\n");
        
    }
    public void Show() // Метод для вывода информации
    {
        Console.WriteLine("ФИО : {0}", _surname, "\t", _name, "\t", _patronymic);
        Console.WriteLine("Группа: {0}", _group);
        Console.WriteLine("возраст :{0}", _age);
        Console.WriteLine("оценка : {0}", _estimation);
    }
}
