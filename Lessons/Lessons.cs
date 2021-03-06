using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task40and42WF;
using System.Reflection;
using Lessons_MyExtension;
using System.Collections;

namespace Lessons
{
    /**
    * class MyClass и struct MyStruct для Task39()
    */
    class MyClass
    {

    }
    struct MyStruct
    {

    }
    /**
    * class MyClass43 и struct MyStruct43 для Task43()
    */
    class MyClass43
    {
        public int a;
        public double b;
        public float c;
    }
    struct MyStruct43
    {
        public int a;
        public double b;
        public float c;
    }
    /**
    * class Item для Task49()
    */
    class Item
    {
        public int Value { get; set; }
        public Item Child { get; set; }
    }
    /*
     * enum для Task54_1() и Task54_4()
     */
    enum DayOfWeek54 : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    /*
     * enum для Task54_2() и Task54_3()
     */
    enum Color
    {
        White,
        Red,
        Green,
        Blue,
        Orange
    }
    /**
     * class Point для Task55()
     */
    class Point
    {
        public int x;
        public int y;
        public Color color;
    }
    /**
     * class Student для Task55_2() и Task56()
     */
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string midleName;
        public int age;
        public string group;
        public void Print()
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Отчество: {midleName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа: {group}");
        }
        public string GetFullName()
        {
            return $"{lastName} {firstName} {midleName}";
        }
    }
    /**
     * class Car56 для Task56_1()
     */
    class Car56
    {
        private int speed = 0;
        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine("Стоим на месте...");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Едем вперёд со скоростью {speed} км\\ч");
            }
            if (speed < 0)
            {
                Console.WriteLine($"Едем назад со скоростью {-speed} км\\ч");
            }
        }
        public void DriveForward()
        {
            speed = 60;
        }
        public void Stop()
        {
            speed = 0;
        }
        public void DriveBackwaed()
        {
            speed = -5;
        }
    }
    /**
    * class Point57 для Task57()
    */
    class Point57
    {
        int z = 3;  //private
        public int x = 1;
        private int y = 44;
        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }
        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }
        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }
    /**
    * class Gun для Task58() и Task59()
    */
    class Gun
    {
        private bool _isLoaded;
        public Gun()
        {

        }
        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;
        }
        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            _isLoaded = true;
            Console.WriteLine("ЗАряжено!");
        }
        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }
            Console.WriteLine("Пыщ-пыщ\n");
            _isLoaded = false;
        }
    }
    /**
    * class Point59 для Task59_2() и Task60()
    */
    class Point59
    {
        private int _x;
        private int _y;
        public Point59(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public Point59()
        {
            _x = _y = 1;
        }
        public void Print()
        {
            Console.WriteLine($"X: {_x}\tY: {_y}");
        }
    }
    /**
     * class Student60 для Task60
     */
    class Student60
    {
        private string _firstName;
        private string _lastName;
        private string _midleName;
        private DateTime _birthday;
        public Student60(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }
        public Student60(string lastName, string firstName, string midleName, DateTime birthday)
        {
            _firstName = firstName;
            _midleName = midleName;
            _lastName = lastName;
            _birthday = birthday;
        }
        public Student60(Student60 student)
        {
            _firstName = student._firstName;
            _midleName = student._midleName;
            _lastName = student._lastName;
            _birthday = student._birthday;
        }
        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nОтчество: {_midleName}\nДата рождения: {_birthday.ToString("dd.MM.yyyy")} г");
        }
    }

    /**
     * class Student61 для Task61
     */
    class Student61
    {
        private string firstName;
        private string lastName;
        private string midleName;
        private DateTime birthday;
        public Student61(string lastName, DateTime birthday)
        {
            this.lastName = lastName;
            this.birthday = birthday;
        }
        public Student61(string lastName, string firstName, string midleName, DateTime birthday) : this(lastName, birthday)
        {
            this.firstName = firstName;
            this.midleName = midleName;
        }
        public Student61(Student61 student)
        {
            firstName = student.firstName;
            midleName = student.midleName;
            lastName = student.lastName;
            birthday = student.birthday;
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {firstName}\nФамилия: {lastName}\nОтчество: {midleName}\nДата рождения: {birthday.ToString("dd.MM.yyyy")} г");
        }
    }
    /**
    * class Point62 для Task62()
    */
    class Point62
    {
        private int x;
        public void SetX(int x)
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }
            if (x > 5)
            {
                this.x = 5;
                return;
            }
            this.x = x;
        }
        public int GetX()
        {
            return x;
        }
        private int y;

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value < 1)
                {
                    y = 1;
                    return;
                }
                if (value > 5)
                {
                    y = 5;
                    return;
                }
                y = value;
            }
        }
        public int Z { get; set; }

    }
    /**
    * class MyClass63 для Task63()
    */
    class MyClass63
    {
        private static int b;
        public void SetB(int b)
        {
            MyClass63.b = b;
        }
        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }
    /**
    * class MyClass64 для Task64()
    */
    class MyClass64
    {
        public MyClass64()
        {
            Counter++;
        }
        private static int counter;

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }
        public int ObjectsCount
        {
            get { return counter; }
        }
        public static int GetCounter()
        {
            return counter;
        }
        public int GetObjectsCount()
        {
            return counter;
        }
    }
    /**
    * class MyClass65 для Task65()
    */
    class MyClass65
    {
        public MyClass65()
        {
            Console.WriteLine("Конструктор");
        }
        static MyClass65()
        {
            Console.WriteLine("Статический конструктор");
        }
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }

    /**
    * class DbRepository для Task65_2()
    */
    class DbRepository
    {
        private static string connectionStritg;
        static DbRepository()
        {
            ConfigurationMenager configurationMenager = new ConfigurationMenager();
            connectionStritg = configurationMenager.GetConnectionStrinf();
        }
        public void GetData()
        {
            Console.WriteLine("Использую: " + connectionStritg);
        }
    }
    /**
    * class ConfigurationMenager для Task65_2()
    */
    class ConfigurationMenager
    {
        public string GetConnectionStrinf()
        {
            return "local DB";
        }
    }
    /**
    * class ConfigurationMenager для Task65_2()
    */
    static class MyClass66
    {
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
        public static void Bar()
        {
            Console.WriteLine("Bar");
        }
    }
    /**
    * class Student67 для Task67_2()
    */
    sealed class Student67
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    /**
    * class Person68 для Task68()
    */
    partial class Person68
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person68(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public partial string GetFullName();
    }
    /**
    * class MyClass69 для Task69()
    */
    class MyClass69
    {
        public const double PI = 3.14;
        public const string MY_ERROR = "some error";
        public readonly int _a;
        public static readonly int _b;
        static MyClass69()
        {
            _b = 3;
        }
        public MyClass69(int a)
        {
            _a = a;
        }
        public void Foo()
        {
            Console.WriteLine(PI);
            Console.WriteLine(MY_ERROR);
            Console.WriteLine(_a);
            Console.WriteLine(_b);
        }
    }
    /**
    * class MyLogger для Task69_2()
    */
    class MyLogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|INFO|\t{message}");
        }
        public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|ERROR|\t{message}");
        }
        public void Warm(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|WARM|\t{message}");
        }
    }
    /**
    * class Car69 для Task69_2()
    */
    class Car69
    {
        private const string ENGINE_IS_STARTED_MESSAGE = "Двигатель запущен!";
        private const string ATTEMPT_TO_START_ENGINE_MESSAGE = "Завожу двигатель!";
        private const string ENGINE_HAS_ALREADY_STARTED_MESSAGE = "Лапоть, двигатель уже запущен!";
        private const string ATTEMPT_TO_DRIVE_MESSAGE = "Тапку в пол!";
        private const string DRIVE_MESSAGE = "Пoeхали!";
        private const string DRIVE_ERROR_MESSAGE = "Лапоть, сначала заведи двигатель!";
        private readonly MyLogger _myLogger;
        private bool isEngineStarted;
        public Car69(MyLogger myLogger)
        {
            _myLogger = myLogger;
        }
        public void StartEngine()
        {
            _myLogger.Info(ATTEMPT_TO_START_ENGINE_MESSAGE);
            if (isEngineStarted)
            {
                _myLogger.Warm(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
            }
            else
            {
                isEngineStarted = true;
                _myLogger.Info(ENGINE_IS_STARTED_MESSAGE);
            }
        }
        public void Drive()
        {
            _myLogger.Info(ATTEMPT_TO_DRIVE_MESSAGE);
            if (isEngineStarted)
            {
                _myLogger.Warm(DRIVE_MESSAGE);
            }
            else
            {
                _myLogger.Info(DRIVE_ERROR_MESSAGE);
            }
        }
    }
    /**
    * class Cat для Task70()
    */
    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Cat()
        {

        }
        public Cat(string name)
        {
            Name = name;
        }
    }
    /**
    * class Person70 для Task70_2()
    */
    partial class Person70
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Person70()
        {

        }
        public Person70(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    /**
    * class Address для Task70_2()
    */
    public class Address
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
    }
    /**
    * class Person71 для Task71()
    */
    partial class Person71
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void PrintName()
        {
            Console.WriteLine($"Меня зовут {FirstName}");
        }
    }
    /**
    * class Student71 для Task71()
    */
    class Student71 : Person71
    {
        public void Learn()
        {
            Console.WriteLine("Я учусь!");
        }
    }
    /**
    * class Point2D для Task72()
    */
    class Point2D
    {
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Вызван конструктор класса Point2D");
        }
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine("X:\t" + X);
            Console.WriteLine("Y:\t" + Y);
        }
    }
    /**
    * class Point3D для Task72()
    */
    class Point3D : Point2D
    {
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("Вызван конструктор класса Point3D");
        }
        public int Z { get; set; }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Z:\t" + Z);
        }
    }
    /**
    * class Point73 для Task73()
    */
    class Point73
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine("X:\t" + X);
            Console.WriteLine("Y:\t" + Y);
        }
    }
    /**
    * class A для Task74()
    */
    class A
    {
        public int publicField;
        private int privateField;
        protected int protectedField;
        public A()
        {
            Console.WriteLine(publicField); //поле доступно
            Console.WriteLine(privateField); //поле доступно
            Console.WriteLine(protectedField); //поле доступно
        }
        public void Foo()
        {
            Console.WriteLine(publicField); //поле доступно
            Console.WriteLine(privateField); //поле доступно
            Console.WriteLine(protectedField); //поле доступно
        }
    }
    /**
    * class B для Task74()
    */
    class B : A
    {
        public B()
        {
            Console.WriteLine(publicField); //поле доступно
            //Console.WriteLine(privateField); //поле недоступно
            Console.WriteLine(protectedField); //поле доступно
        }
    }
    /**
    * class Car75 для Task75()
    */
    class Car75
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Двигатель запущен!");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("Я машина, я еду!");
        }
    }
    /**
    * class SportCar75 для Task75()
    */
    class SportCar75 : Car75
    {
        protected override void StartEngine()
        {
            Console.WriteLine("Рон дон дон!");
        }
        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("Я еду очень быстро!");
        }
    }
    /**
    * class Person75 для Task75()
    */
    class Person75
    {
        public void Drive(Car75 car)
        {
            car.Drive();
        }
    }
    /**
    * class Weapon76 для Task76()
    */
    abstract class Weapon76
    {
        public abstract int Damage { get; }
        public abstract void Fire();
        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damage}");
        }
    }
    /**
    * class Gun76 для Task76()
    */
    class Gun76 : Weapon76
    {
        public override int Damage { get { return 5; } }

        public override void Fire()
        {
            Console.WriteLine("Пыщ!");
        }
    }
    /**
    * class Gun76 для Task76()
    */
    class LaserGun76 : Weapon76
    {
        public override int Damage { get { return 8; } }
        public override void Fire()
        {
            Console.WriteLine("Пиу!");
        }
    }
    /**
    * class Gun76 для Task76()
    */
    class Bow76 : Weapon76
    {
        public override int Damage => 3;

        public override void Fire()
        {
            Console.WriteLine("Чпуньк!");
        }
    }
    /**
    * class Player76 для Task76()
    */
    class Player76
    {
        public void Fire(Weapon76 weapon)
        {
            weapon.Fire();
        }
        public void CheckInfo(Weapon76 weapon)
        {
            weapon.ShowInfo();
        }
    }
    /**
    * interface IDataProvider для Task77()
    */
    interface IDataProvider
    {
        string GetData();
    }
    /**
    * interface IDataProcessor для Task77()
    */
    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }
    /**
     * class ConsoleDataProcessor реализует интерфейс IDataProcessor
     */
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }
    /**
     * классы DbDataProvider, FileDataProvider и APIDataProvider реализуют интерфейс IDataProvider
     */
    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из БД";
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файла";
        }
    }
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из API";
        }
    }
    /**
    * interface IFirstInterface и ISecondInterface для Task79()
    */
    interface IFirstInterface
    {
        void Action();
    }
    interface ISecondInterface
    {
        void Action();
    }
    /**
     * классы MyClass79 и MyOtherClass реализуют интерфейсы IFirstInterface, ISecondInterface
     */
    class MyClass79 : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("MyClass Action...");
        }
    }
    class MyOtherClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("MyOtherClass IFirstInterface.Action");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine("MyOtherClass ISecondInterface.Action");
        }
    }
    /**
     * класс MyList для Task83_2()
     */
    public class MyList<T>
    {
        private T[] _array = Array.Empty<T>();
        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
        public int Count { get { return _array.Length; } }
        public void Add(T value)
        {
            var newArray = new T[_array.Length + 1];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[_array.Length] = value;
            _array = newArray;
        }
    }
    /**
     * класс SwapTestClass для Task84()
     */
    public static class SwapTestClass
    {
        public static void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }
    }
    /// <summary>
    /// C# УРОКИ | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
    /// By #SimpleCode (https://www.youtube.com/c/SimpleCodeIT/featured)
    /// </summary>
    public class Lessons
    {
        /**
         * Типы данных
         */
        public static void Task3()
        {
            string msg = "Тип {0,8} |\t.NET {1,8} |\tРазмер = {2} \t| MIN = {3,30}\t| MAX = {4}";
            Console.Title = "Типы данных в C#";
            Console.WriteLine("\n\t\t\t\t\tЧИСЛОВЫЕ (целочисленные) ТИПЫ:\n");
            Console.WriteLine(string.Format(msg, "byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(string.Format(msg, "sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
            Console.WriteLine(string.Format(msg, "short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(string.Format(msg, "ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(string.Format(msg, "int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));
            Console.WriteLine(string.Format(msg, "uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));
            Console.WriteLine(string.Format(msg, "long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));
            Console.WriteLine(string.Format(msg, "ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));
            Console.WriteLine("\n\t\t\t\t\tЧИСЛОВЫЕ (с плавающей точкой) ТИПЫ:\n");
            Console.WriteLine(string.Format(msg, "float", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue));
            Console.WriteLine(string.Format(msg, "double", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue));
            Console.WriteLine(string.Format(msg, "decimal", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue));
            Console.WriteLine("\n\t\t\t\t\tСИМВОЛЬНЫЕ ТИПЫ:\n");
            Console.WriteLine(string.Format(msg, "char", typeof(char).Name, sizeof(char), char.MinValue, char.MaxValue));
            Console.WriteLine(string.Format(msg, "string", typeof(string).Name, "N/A", "N/A", "N/A"));
            Console.WriteLine("\n\t\t\t\t\tЛОГИЧЕСКИЙ ТИП:\n");
            Console.WriteLine(string.Format(msg, "bool", typeof(bool).Name, sizeof(bool), bool.FalseString, bool.TrueString));
            Console.WriteLine("\n\t\t\t\t\tОСОБЫЕ ТИПЫ:\n");
            Console.WriteLine(string.Format(msg, "object", typeof(object).Name, "N/A", "N/A", "N/A"));
            Console.WriteLine(string.Format(msg, "dynamic", "N/A", "N/A", "N/A", "N/A"));
        }
        /**
         * Переменные в C#
         * 
         * Объявление (создание) переменных
         * 
         * Инициализация переменных
         * 
         * Присвоение значения переменной (помещение данных)
         */
        public static void Task4()
        {
            Console.WriteLine("Hello World!");
            bool q = true;
            Boolean qw = true;
            Console.WriteLine($"{q} + {qw}");
            var chars = new[]
            {
            'j',
            '\u006A',
            '\x006A',
            (char)106,
            };
            char w = (char)106;
            Console.WriteLine(w);
            Console.WriteLine(string.Join(" ", chars));
            object qwe = '1';
            Console.WriteLine($"{qwe}");
            qwe = "123";
            Console.WriteLine($"{qwe}");
            qwe = 12345;
            Console.WriteLine($"{qwe}");
            Console.WriteLine(System.Text.RegularExpressions.Match.Equals(2, 2));
        }
        /**
         * Ввод данных в консоль
         */
        public static void Task5()
        {
            string data;
            data = Console.ReadLine();
            Console.WriteLine("Првиет " + data + "!!!");
        }
        /**
         * Конвертация строки
         * класс Convert
         */
        public static void Task6()
        {
            string str;
            int a, b;
            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Введите второе число");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            int result = a + b;
            Console.WriteLine("Сумма чисел = " + result);
        }
        /**
         * Конвертация строки
         * класс Convert
         * класс NumberFormatInfo для double
         */
        public static void Task6_1()
        {
            string str = "1.55";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            double a = Convert.ToDouble(str, numberFormatInfo);
            Console.WriteLine(a);

            str = "1,44";
            a = Convert.ToDouble(str);
            Console.WriteLine(a);

            a = 1.33;
            Console.WriteLine(a);
        }
        /**
         * конвертация строки
         * parse и tryparse
         */
        public static void Task7()
        {
            string str = "5";
            int a = int.Parse(str);
            Console.WriteLine(a);

            str = "5,9";
            double b = double.Parse(str);
            Console.WriteLine(b);

            str = "5.99";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            b = double.Parse(str, numberFormatInfo);
            Console.WriteLine(b);

            str = "1 asd asdaa";
            bool result = int.TryParse(str, out a);
            if (result)
            {
                Console.WriteLine("Операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }
        }
        /**
         * ОПЕРАТОРЫ
         * 
         * Арифметические операции с числами (+,-,*,/,%)
         */
        public static void Task8()
        {
            int a = 2;
            int b = 5;
            int result = a + b;
            Console.WriteLine(result);

            double res = (double)a / b;
            Console.WriteLine(res);

            a = 10;
            b = 3;
            result = a % b;
            Console.WriteLine(result);

            int c = 5;
            result = a + b + c;
            Console.WriteLine(result);

            result = a + 5;
            Console.WriteLine(result);
        }
        /**
         * Приоритет арифметических операций
         */
        public static void Task9()
        {
            int result = 2 + 2 * 2;
            Console.WriteLine(result);

            result = 5 * (4 / 2);
            Console.WriteLine(result);

            result = 5 - 1 + 2;
            Console.WriteLine(result);
        }
        /**
         * Несколько проектов в одном решении
         */
        public static void Task10()
        {
            Console.WriteLine("Hello World from Lessons!!!");
        }
        /**
         * Инкремент и декремент. Постфиксный и префиксный.
         */
        public static void Task11()
        {
            int a = 0;
            a++;
            Console.WriteLine(a);

            a = 1;
            a = ++a * a;
            Console.WriteLine(a);

            a = 1;
            a = a++ * a;
            Console.WriteLine(a);
        }
        /**
         * Операотры отношений
         * Операции сравнения
         */
        /*
         *          ==  Равно
         *          !=  Не равно
         *          >   Больше   
         *          <   Меньше
         *          >=  Больше или равно
         *          <=  Меньше или равно
         */
        public static void Task12()
        {
            int a = 5;
            int b = 5;
            bool result = a == b;
            Console.WriteLine(result);

            a = 5;
            b = 4;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);


        }
        /**
         * конструкция if else
         */
        /*
         *          if(утверждение или выражение)
         *          {
         *              действие_1;
         *          }
         *          else
         *          {
         *              действие_2;
         *          }
         */
        public static void Task13()
        {
            bool isInfected = true;
            if (isInfected)
            {
                Console.WriteLine("Персонаж инфицирован!");
            }
            else
            {
                Console.WriteLine("Персонаж здоров!");
            }

            int a;
            a = int.Parse(Console.ReadLine());
            if (a == 5)
            {
                Console.WriteLine("a равно 5");
            }
            else
            {
                Console.WriteLine("a не равно 5");
            }
        }
        /**
         * Логические операторы
         */
        /*
         *          &&      Сокращенное И
         *          ||      Сокращенное ИЛИ
         *          &       И
         *          |       ИЛИ
         *          !       Не (унарный)
         */
        public static void Task14()
        {
            bool isInfected = false;
            if (!isInfected)
            {
                Console.WriteLine("Персонаж здоров!");
            }
            else
            {
                Console.WriteLine("Персонаж инфицирован!");
            }

            int fanSpeed = 0;
            bool isHighTemperature = false;
            bool hasNoCooling = fanSpeed <= 0;
            if (isHighTemperature || hasNoCooling)      //если первое поле true второе даже не проверяется
            {
                Console.WriteLine("Угроза повреждения процессова!!!");
            }

            if (GetTemperature() | GetCoolingStatus())  //разница в том что проверяються оба поля даже если первое true
            {
                Console.WriteLine("Угроза повреждения процессова!!!");
            }
        }
        /**
         * Вспомогательный метод для Task14()
         */
        public static bool GetTemperature()
        {
            return true;
        }
        /**
         * Вспомогательный метод для Task14()
         */
        public static bool GetCoolingStatus()
        {
            return true;
        }
        /**
         * Условный оператор switch
         */
        public static void Task15()
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                    Console.WriteLine("Вы ввели число 1 или 2");
                    break;
                default:
                    Console.WriteLine("Я не знаю, что делать с этим числом!");
                    break;
            }

            string b = Console.ReadLine();
            switch (b)
            {
                case "+":
                    Console.WriteLine("Вы ввели плюс");
                    break;
                case "-":
                    Console.WriteLine("Вы ввели минус");
                    break;
                default:
                    Console.WriteLine("Вы ввели неизвестный символ!");
                    break;
            }
        }
        /**
        * Условный оператор switch и enum ConsoleKey
        */
        public static void Task15_1()
        {
            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch (consoleKey)
            {
                case ConsoleKey.Backspace:
                    Console.WriteLine("Вы нажали Backspace!");
                    break;
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.Clear:
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Pause:
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.PageUp:
                    break;
                case ConsoleKey.PageDown:
                    break;
                case ConsoleKey.End:
                    break;
                case ConsoleKey.Home:
                    break;
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.Select:
                    break;
                case ConsoleKey.Print:
                    break;
                case ConsoleKey.Execute:
                    break;
                case ConsoleKey.PrintScreen:
                    break;
                case ConsoleKey.Insert:
                    break;
                case ConsoleKey.Delete:
                    break;
                case ConsoleKey.Help:
                    break;
                case ConsoleKey.D0:
                    break;
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                case ConsoleKey.D7:
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                    break;
                case ConsoleKey.A:
                    break;
                case ConsoleKey.B:
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.E:
                    break;
                case ConsoleKey.F:
                    break;
                case ConsoleKey.G:
                    break;
                case ConsoleKey.H:
                    break;
                case ConsoleKey.I:
                    break;
                case ConsoleKey.J:
                    break;
                case ConsoleKey.K:
                    break;
                case ConsoleKey.L:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.N:
                    break;
                case ConsoleKey.O:
                    break;
                case ConsoleKey.P:
                    break;
                case ConsoleKey.Q:
                    break;
                case ConsoleKey.R:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.T:
                    break;
                case ConsoleKey.U:
                    break;
                case ConsoleKey.V:
                    break;
                case ConsoleKey.W:
                    break;
                case ConsoleKey.X:
                    break;
                case ConsoleKey.Y:
                    break;
                case ConsoleKey.Z:
                    break;
                case ConsoleKey.LeftWindows:
                    break;
                case ConsoleKey.RightWindows:
                    break;
                case ConsoleKey.Applications:
                    break;
                case ConsoleKey.Sleep:
                    break;
                case ConsoleKey.NumPad0:
                    break;
                case ConsoleKey.NumPad1:
                    break;
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.NumPad4:
                    break;
                case ConsoleKey.NumPad5:
                    break;
                case ConsoleKey.NumPad6:
                    break;
                case ConsoleKey.NumPad7:
                    break;
                case ConsoleKey.NumPad8:
                    break;
                case ConsoleKey.NumPad9:
                    break;
                case ConsoleKey.Multiply:
                    break;
                case ConsoleKey.Add:
                    break;
                case ConsoleKey.Separator:
                    break;
                case ConsoleKey.Subtract:
                    break;
                case ConsoleKey.Decimal:
                    break;
                case ConsoleKey.Divide:
                    break;
                case ConsoleKey.F1:
                    break;
                case ConsoleKey.F2:
                    break;
                case ConsoleKey.F3:
                    break;
                case ConsoleKey.F4:
                    break;
                case ConsoleKey.F5:
                    break;
                case ConsoleKey.F6:
                    break;
                case ConsoleKey.F7:
                    break;
                case ConsoleKey.F8:
                    break;
                case ConsoleKey.F9:
                    break;
                case ConsoleKey.F10:
                    break;
                case ConsoleKey.F11:
                    break;
                case ConsoleKey.F12:
                    break;
                case ConsoleKey.F13:
                    break;
                case ConsoleKey.F14:
                    break;
                case ConsoleKey.F15:
                    break;
                case ConsoleKey.F16:
                    break;
                case ConsoleKey.F17:
                    break;
                case ConsoleKey.F18:
                    break;
                case ConsoleKey.F19:
                    break;
                case ConsoleKey.F20:
                    break;
                case ConsoleKey.F21:
                    break;
                case ConsoleKey.F22:
                    break;
                case ConsoleKey.F23:
                    break;
                case ConsoleKey.F24:
                    break;
                case ConsoleKey.BrowserBack:
                    break;
                case ConsoleKey.BrowserForward:
                    break;
                case ConsoleKey.BrowserRefresh:
                    break;
                case ConsoleKey.BrowserStop:
                    break;
                case ConsoleKey.BrowserSearch:
                    break;
                case ConsoleKey.BrowserFavorites:
                    break;
                case ConsoleKey.BrowserHome:
                    break;
                case ConsoleKey.VolumeMute:
                    break;
                case ConsoleKey.VolumeDown:
                    break;
                case ConsoleKey.VolumeUp:
                    break;
                case ConsoleKey.MediaNext:
                    break;
                case ConsoleKey.MediaPrevious:
                    break;
                case ConsoleKey.MediaStop:
                    break;
                case ConsoleKey.MediaPlay:
                    break;
                case ConsoleKey.LaunchMail:
                    break;
                case ConsoleKey.LaunchMediaSelect:
                    break;
                case ConsoleKey.LaunchApp1:
                    break;
                case ConsoleKey.LaunchApp2:
                    break;
                case ConsoleKey.Oem1:
                    break;
                case ConsoleKey.OemPlus:
                    break;
                case ConsoleKey.OemComma:
                    break;
                case ConsoleKey.OemMinus:
                    break;
                case ConsoleKey.OemPeriod:
                    break;
                case ConsoleKey.Oem2:
                    break;
                case ConsoleKey.Oem3:
                    break;
                case ConsoleKey.Oem4:
                    break;
                case ConsoleKey.Oem5:
                    break;
                case ConsoleKey.Oem6:
                    break;
                case ConsoleKey.Oem7:
                    break;
                case ConsoleKey.Oem8:
                    break;
                case ConsoleKey.Oem102:
                    break;
                case ConsoleKey.Process:
                    break;
                case ConsoleKey.Packet:
                    break;
                case ConsoleKey.Attention:
                    break;
                case ConsoleKey.CrSel:
                    break;
                case ConsoleKey.ExSel:
                    break;
                case ConsoleKey.EraseEndOfFile:
                    break;
                case ConsoleKey.Play:
                    break;
                case ConsoleKey.Zoom:
                    break;
                case ConsoleKey.NoName:
                    break;
                case ConsoleKey.Pa1:
                    break;
                case ConsoleKey.OemClear:
                    break;
                default:
                    break;
            }
        }
        /**
         * Цикл while
         */
        public static void Task16()
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }

        }
        /**
         * Цикл do while
         */
        public static void Task17()
        {
            int count = 0;
            do
            {
                count++;
                Console.WriteLine(count);
            } while (count < 5);
        }
        /**
         * Цикл for
         */
        public static void Task18()
        {
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
            }
        }
        /**
         * Цикл for Особенности
         * несколько переменных
         * Цикл for в обратном порядке
         * несколько условий
         */
        public static void Task19()
        {
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
            }

            for (; ; )
            {
                Console.WriteLine("for is working");
                Thread.Sleep(300);
                break;
            }

            int k = 0;
            for (; k < 3; k++)
            {
                Console.WriteLine("for_1: " + k);
            }
            for (; k < 5; k++)
            {
                Console.WriteLine("for_2: " + k);
            }

            for (int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }

            for (int i = int.Parse(Console.ReadLine()); i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0, j = 5; i < 5; i++, j--)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }
        }
        /**
         * Ключевое слово break
         */
        public static void Task20()
        {
            for (int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();
                if (msg == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }
        /**
         * Ключевое слово continue
         */
        public static void Task21()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        /**
         * Вложениые цыклы
         */
        public static void Task22()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация №: " + i);
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("\tЦикл 2 итерация №: " + j);
                    for (int k = 1; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tЦикл 3 итерация №: " + k);
                    }
                }
            }

            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        /**
         * Вспомогательный метод для Task22_1
         */
        public static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }
            return result;
        }
        /**
         * Вложениые цыклы. Пример с 2-х мерным массивом
         */
        public static void Task22_1()
        {
            int rows = 5;
            int columns = 10;
            var myArray = GetRandomArray(rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        /**
         * Тернарный оператор
         * 
         * [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_false]
         */
        public static void Task23()
        {
            int a = 0;
            int b = 1;
            int c = 0;
            //унарный оператор
            a++;
            //бинарный оператор
            c = a + b;

            bool accessAllowed;
            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();
            //if (storedPassword == enteredPassword)
            //{
            //    accessAllowed = true;
            //}
            //else
            //{
            //    accessAllowed = false;
            //}
            accessAllowed = storedPassword == enteredPassword ? true : false; //Тернарный оператор
            Console.WriteLine(accessAllowed);

            int inputData = int.Parse(Console.ReadLine());
            int outputData = inputData < 0 ? 1 : inputData; //Тернарный оператор
            Console.WriteLine(outputData);
        }
        /**
         * Одномерные массивы
         * 
         * Тип_элементов_массива [] имя_масива;
         */
        public static void Task24()
        {
            int[] myArray;
            myArray = new int[5];
            myArray[1] = 3;
            myArray[0] = 10;
            int a = myArray[0];
            int b = myArray.Length;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        /**
         * Массивы
         * 
         * Одномерные массивы
         * 
         * Способы инициализации масива
         */
        public static void Task25()
        {
            int[] myArray1 = new int[5];
            int[] myArray2 = new int[5] { 5, 6, 9, 7, 8 };
            int[] myArray3 = new int[] { 5, 6, 9, 7 };
            int[] myArray4 = new[] { 5, 6, 9, 7 };
            int[] myArray5 = { 5, 6, 9, 7 };
            int[] myArray6 = Enumerable.Repeat(5, 10).ToArray();
            int[] myArray7 = Enumerable.Range(4, 5).ToArray();
        }
        /**
         * Массивы и цыклы
         */
        public static void Task26()
        {
            int[] myArray = { 10, 3, 2, 55 };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
        /**
         * Как работать с массивами в C# на самом деле
         */
        public static void Task27()
        {
            int[] myArray = { 111, 10, 4, 10, 111, 64, 77, 4, 42, 5 };
            Console.WriteLine(myArray.Min());   // using System.Linq;
            Console.WriteLine(myArray.Sum());
            Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());
            int[] result = myArray.Distinct().ToArray();
            int[] result2 = myArray.OrderBy(i => i).ToArray();
            int[] result3 = myArray.OrderByDescending(i => i).ToArray();
            Array.Sort(myArray);
            int result4 = Array.Find(myArray, i => i < 70);
            int result5 = Array.FindLast(myArray, i => i < 70);
            int[] result6 = Array.FindAll(myArray, i => i < 70);
            int result7 = Array.FindIndex(myArray, i => i == 111);   //если нужного елемента в масиве нет то вернется -1
            int result8 = Array.FindLastIndex(myArray, i => i == 111);
            Array.Reverse(myArray); //записывает массив задом на перед
            int result9 = myArray.Where(i => i < 70).FirstOrDefault();  //Тоже самое что Array.Find(myArray, i => i < 70), дефол = 0 (дефолт нужен если мы не найдем таких значений)
        }
        /**
         * Индексы и диапазоны (для .Net Core)
         */
        public static void Task28()
        {
            //Goto proj LessonsCore
        }
        /**
         * Многомерные массивы
         * 
         * Двумерный прямоугольный массив
         */
        public static void Task29()
        {
            //Теория
        }
        /**
         * Многомерные массивы
         * 
         * Двумерный прямоугольный массив
         * 
         * Объявление (создание)
         * 
         * Инициализация
         * 
         * Обращение к элементам двумерного массива
         */
        public static void Task30()
        {
            //тип_данных [,] имя_массива;
            int[,] myArray = new int[3, 5]
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,2,65,78,13}
            };
            int[,] myArray2 = new int[,]
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,2,65,78,13}
            };
            int[,] myArray3 =
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,2,65,78,13}
            };
            Console.WriteLine(myArray[0, 2]);
            Console.WriteLine(myArray2[0, 2]);
            Console.WriteLine(myArray3[0, 2]);
        }
        /**
         * Вывод двумерного массива
         */
        public static void Task31()
        {
            int[,] myArray = new int[,]
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,2,65,78,13},
                {6,3,151,5,65 }
            };
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myArray.Rank);    // размерность массива 
            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        /**
         * Заполнение двумерного массива случайными числами
         * 
         * Заполнение двумерного массива с клавиатуры
         */
        public static void Task32()
        {
            int[,] myArray = new int[2, 3];
            GetRandomArray(myArray.GetLength(0), myArray.GetLength(1));
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + " X: " + j);
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        /**
         * Ступенчатые (зубчатые) массивы
         */
        public static void Task33()
        {
            int[][] myArray = new int[5][];
            //int[,] myArray2 = new int[3, 5];
            //int myArrayRank = myArray.Rank;
            //int myArray2Rank = myArray2.Rank;
            //int myArrayLength = myArray.Length;
            //int myArray2Length = myArray2.Length;
            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[8];
            myArray[3] = new int[3];
            myArray[4] = new int[7];
            myArray[0][3] = 55;
            int[] arr = myArray[0];
            Console.WriteLine(myArray[0][3]);
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
        /**
         * Трёхмерные и более массивы
         */
        public static void Task34()
        {
            int[,,] myArray =
                {
                    {
                        {2,3,5 },
                        {69,7,4 }
                    },

                    {
                        {4,31,24 },
                        {64,7,33 }
                    },

                    {
                        {4,21,9 },
                        {8,12,1 }}
                    };
            myArray[0, 1, 2] = 55;
            Console.WriteLine(myArray[0, 1, 2]);
            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(100);
                    }
                }
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page №: " + (i + 1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('_', 20));
            }
            int[][][] myArrayStepped = new int[random.Next(3, 6)][][];
            for (int i = 0; i < myArrayStepped.Length; i++)
            {
                myArrayStepped[i] = new int[random.Next(2, 6)][];
                for (int j = 0; j < myArrayStepped[i].Length; j++)
                {
                    myArrayStepped[i][j] = new int[random.Next(2, 6)];
                    for (int k = 0; k < myArrayStepped[i][j].Length; k++)
                    {
                        myArrayStepped[i][j][k] = random.Next(100);
                    }
                }
            }
            Console.WriteLine("\n\n\nNext BOOK");
            for (int i = 0; i < myArrayStepped.Length; i++)
            {
                Console.WriteLine("Page №: " + (i + 1));
                for (int j = 0; j < myArrayStepped[i].Length; j++)
                {
                    for (int k = 0; k < myArrayStepped[i][j].Length; k++)
                    {
                        Console.Write(myArrayStepped[i][j][k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('_', 20));
            }
        }
        /**
         * Функции и методы
         */

        //      модификаторы тип_возвращаемого_значения название_метода([параметры])
        //      {
        //          тело_метода;
        //      }
        public static void Task35()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = Sum(a, b);
            PrintResult(c);
            PrintLine();
        }
        /**
         * Вспомогательный метод для Task35() и Task36()
         */
        static int Sum(int value_1, int value_2)
        {
            return value_1 + value_2;
        }
        /**
         * Вспомогательный метод для Task35()
         */
        static void PrintResult(int result)
        {
            Console.WriteLine("Результат сложения: " + result);
        }
        /**
         * Вспомогательный метод для Task35()
         */
        static void PrintLine()
        {
            Console.WriteLine("Метод PrintLine был вызван!");
        }
        /**
         * Перегрузка методов
         */
        public static void Task36()
        {
            int result = Sum(2, 3);
            Console.WriteLine(result);
            result = Sum(4, 5, 6);
            Console.WriteLine(result);
        }
        /// <summary>
        /// Вспомогательный метод для Task36().
        /// Возвращает сумму двух целых чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// Вспомогательный метод для Task36().
        /// Возвращает сумму двух дробных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }
        /**
         * Область видимости, или контекст переменной 
         * 
         * Конфликты областей видимости
         */
        public static void Task37()
        {
            int a = 2;
            for (int i = 0; i < 10; i++)
            {
                i++;
                a++;
            }
            a++;
            Console.WriteLine(a);
        }
        /**
         * Ссылочные (reference types) и значимые (value types) типы
         * 
         * Стек(stack) и куча (heap)
         */
        public static void Task38()
        {
            int a = 1;
            Foo(a);
            Console.WriteLine(a);

            int[] arr = new int[1];
            arr[0] = 1;
            Bar(arr);
            Console.WriteLine(arr[0]);
        }
        /**
         * Вспомогательный метод для Task38()
         */
        static void Foo(int a)
        {
            a = 5;
        }
        /**
         * Вспомогательный метод для Task38()
         */
        static void Bar(int[] arr)
        {
            arr[0] = 5;
        }
        /**
         * что такое null
         */
        public static void Task39()
        {
            bool b;
            int a;
            double d;
            Random random;
            int[] arr;
            MyClass myClass;
            MyStruct myStruct;
            arr = new int[10];
            arr = null;
        }
        /**
         * оператор null-объединения    ??
         */
        public static void Task40()
        {
            string str = null;
            string result = str ?? "Нет данных";
            Console.WriteLine(result);
            str = "test";
            Console.WriteLine("Количиство символов в строке " + str.Length);
            str = null;
            result = str ?? string.Empty;
            Console.WriteLine("Количиство символов в строке " + result.Length);
        }
        /**
         * Оператор присваивания объединения со значением NULL ??=
         */
        public static void Task41()
        {
            string str = null;
            str ??= string.Empty;
            Console.WriteLine("Количество символов в строке " + str.Length);

            int[] myArray = GetArray();
            myArray ??= new int[0];
            Console.WriteLine("Количество элементов в массиве " + myArray.Length);
        }
        /**
         * Вспомогательный метод для Task41() и Task42()
         */
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }
        /**
         * Оператор условного null ?.
         */
        public static void Task42()
        {
            int[] myArray = GetArray();
            Console.WriteLine("Сумма элементов массива " + (myArray?.Sum() ?? 0));

            myArray = GetArray42();
            Console.WriteLine("Сумма элементов массива " + (myArray?.Sum() ?? 0));

            Person person = GetPerson();
            string phoneNumber = person?.Contacts?.PhoneNumber ?? "Нет данных"; // Если хотя бы на одном из уровней переменной person будет null то на вывод мы получим "Нет данных"
            Console.WriteLine(phoneNumber);
        }
        /**
         * Вспомогательный метод для Task42()
         */
        static int[] GetArray42()
        {
            int[] myArray = { 1, 2, 3 };
            return myArray;
        }
        /**
         * Вспомогательный метод для Task42()
         */
        static Person GetPerson()
        {
            Person person = new Person() { Contacts = new Contacts() { PhoneNumber = "1234567890" } };
            return person;
        }
        /**
         * Ключевое слово ref
         * 
         * Передача аргументов по ссылке
         */
        public static void Task43()
        {
            int a = 2;
            Foo(ref a);
            Console.WriteLine(a);

            MyStruct43 myStruct = new MyStruct43();
            Foo(ref myStruct);

            MyClass43 myClass = new MyClass43();
            Foo(myClass);

            int[] myArray = { 1, 4, 6 };
            Bar(myArray);

            Bar(ref myArray);

            int[] myArray43 = { 1, 4, 6 };
            Bar43(myArray43);

            Bar43(ref myArray43);
        }
        /**
         * Вспомогательный методы для Task43()
         */
        static void Foo(ref int a)
        {
            a = -5;
        }
        static void Foo(ref MyStruct43 myStruct)
        {
            myStruct.a = -5;
        }
        static void Foo(MyClass43 myClass)
        {
            myClass.a = -5;
        }
        static void Bar(ref int[] arr)
        {
            arr = null;
        }
        static void Bar43(int[] arr)
        {
            arr = new int[10];
        }
        static void Bar43(ref int[] arr)
        {
            arr = new int[10];
        }
        /**
         * Ссылочные локальные переменные 
         * 
         * Возвращаемые ссылочные значения
         */
        public static void Task43_2()
        {
            int[] arr = { 2, 6, 1 };
            int b = arr[0];
            b = -5;

            ref int a = ref arr[0];
            a = -5;

            ref int c = ref Foo(arr);
            c = -5;
        }
        /**
         * Вспомогательный метод для Task43_2()
         */
        static ref int Foo(int[] numbers)
        {
            return ref numbers[0];
        }
        /**
         * ключевое слово out
         * 
         * разница между ref и out
         */
        public static void Task44()
        {
            Bar(out int a);
            Console.WriteLine(a);

            string str = Console.ReadLine();
            int.TryParse(str, out int result);
            Console.WriteLine(result);
        }
        /**
         * Вспомогательный метод для Task44()
         */
        static void Bar(out int value)
        {
            value = 5;
        }
        /**
         * ключевое слово in
         */
        public static void Task45()
        {
            int a = 5;
            Foo45(a);
        }
        /**
         * Вспомогательный метод для Task45()
         */
        static void Foo45(in int value)
        {
            Console.WriteLine(value);
        }
        /**
         * Ключевое слово params
         */
        public static void Task46()
        {
            int result = Sum("test", 5, 10, 4, 7, 9);
            Console.WriteLine(result);

            Foo("test", 5, 'q', 5.89f, true);
        }
        /**
         * Вспомогательный метод для Task46()
         */
        static int Sum(string massege, params int[] parameters) //params в параметрах только один и только в конце
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }
        /**
         * Вспомогательный метод для Task46()
         */
        static void Foo(params object[] parameters)
        {
            string messege = "Тиа данных {0}, значение {1}";
            foreach (var item in parameters)
            {
                Console.WriteLine(messege, item.GetType(), item);
            }
        }
        /**
         * Необязательные параметры методов
         */
        public static void Task47()
        {
            int result = Sum(5, 10, true);
        }
        /**
         * Вспомогательный метод для Task47() и Task48() 
         */
        static int Sum(int a, int b, bool enableLogging = false) //параметры по умолчанию в конце списка всех параметров
        {
            int result = a + b;
            if (enableLogging)
            {
                Console.WriteLine("Значение переменной a = " + a);
                Console.WriteLine("Значение переменной b = " + b);
                Console.WriteLine("Результат сложения = " + result);
            }
            return result;
        }
        /**
         * Именованные параметры
         */
        public static void Task48()
        {
            int firstValue = 10;
            int secondValue = 5;
            int result = Sum(enableLogging: true, b: secondValue, a: firstValue);
        }
        /**
         * Рекурсия
         * 
         * Методы и стек
         * 
         * Переполнения стека
         */
        public static void Task49()
        {
            Foo49(0);
            Item item = InitItem();
            Print49(item);
            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }
        }
        /**
         * Вспомогательный метод для Task49 
         */
        static void Foo49(int i)
        {
            Console.WriteLine(i);
            if (i >= 3)
            {
                return;
            }
            i++;
            Foo49(i);
        }
        /**
         * Вспомогательный метод для Task49 
         */
        static Item InitItem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }
            };
        }
        /**
         * Вспомогательный метод для Task49 
         */
        static void Print49(Item item)
        {
            if (item != null)
            {
                Console.WriteLine(item.Value);
                Print49(item.Child);
            }
        }
        /**
         * Преобразование и приведение приметивных типов в C#
         */
        public static void Task50()
        {
            int a = 5;
            float b = a;
            double c = 5.2;
            float d = (float)c;
            float e = 2.5F;
            int result = (int)(a + e);
            Foo50(a);
            Foo50((float)c);
        }
        /**
         * Вспомогательный метод для Task49 
         */
        static void Foo50(float value)
        {
            Console.WriteLine(value);
        }
        /**
         * "Ядерный Ганди" и арифметическое переполнение
         */
        public static void Task51()
        {
            byte aggression = 1;
            byte democracyModifier = 2;
            try
            {
                checked // проверка на переполнение
                {
                    aggression = (byte)(aggression - democracyModifier);    //сужающее преобразование данных
                }
                Console.WriteLine(aggression);
            }
            catch (OverflowException)
            {

                Console.WriteLine("Ошибка Переполнения!");
            }
        }
        public static void Task51_1()
        {
            int a = int.MaxValue;
            a = a + 1;  //переполнение через верхнюю границу
            Console.WriteLine(a);

            int b = int.MinValue;
            b = b - 1;  //переполнение через нижнюю границу
            Console.WriteLine(b);
        }
        public static void Task51_2()
        {
            double a = 1.0 / 0.0;
            Console.WriteLine(double.IsInfinity(a));    // output: True
            double b = 0.0 / 0.0;
            Console.WriteLine(double.IsNaN(b)); // output: True
            double c = double.MaxValue + double.MaxValue;
            Console.WriteLine(double.IsInfinity(c));    // output: True
        }
        public static void Task51_3()
        {
            try
            {
                decimal a = decimal.MaxValue;
                decimal b = decimal.MaxValue;
                decimal c = unchecked(a + b);   //Для операндов типа decimal арифметическое переполнение всегда вызыва исключение
            }
            catch (OverflowException)
            {

                Console.WriteLine("Ошибка Переполнения!");
            }

        }
        /**
         * NULL-совместимые значимые типы (Nullable)
         */
        public static void Task52()
        {
            string str = null;
            //int a = null;
            DateTime? dateTime = null;
        }
        public static void Task52_1()
        {
            int? i = null;
            Console.WriteLine(i == null); //True
            Console.WriteLine(i.HasValue); //False
            Console.WriteLine(i.GetValueOrDefault()); //0
            Console.WriteLine(i.GetValueOrDefault(3)); //3
            Console.WriteLine(i ?? 55); //55
            //Console.WriteLine(i.Value); //InvalidOperationException
            Console.WriteLine(i);
        }
        public static void Task52_2()
        {
            int? i = 2;
            Console.WriteLine(i);
            Console.WriteLine(i == null); //False
            Console.WriteLine(i.HasValue); //True
            Console.WriteLine(i.GetValueOrDefault()); //2
            Console.WriteLine(i.GetValueOrDefault(3)); //2
            Console.WriteLine(i ?? 55); //2
            Console.WriteLine(i.Value); //2
        }
        public static void Task52_3()
        {
            Nullable<DateTime> dateTime = DateTime.Now;
            DateTime? dateTime1 = null;
            Console.WriteLine(dateTime);
        }
        public static void Task52_4()
        {
            int a = 5;
            int? b = 22;
            int? result = a + b;
            Console.WriteLine(result);
            Console.WriteLine(a == b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);

        }
        /**
         * Ключевое слово var
         * 
         * неявно типизированные локальные переменные 
         */
        public static void Task53()
        {
            var t = 5;
            var w = new Dictionary<int, string>();
            var r = new List<byte>();
            var e = new { Name = "Мартин", Age = 25 };
            Console.WriteLine(t.GetType());
            Console.WriteLine(w.GetType());
            Console.WriteLine(r.GetType());
            Console.WriteLine(e.GetType());
        }
        public static void Task53_2()
        {
            int[] numbers = { 1, 5, 344, 40, 1, 24, 6, 9, 11 };
            var result = from i in numbers where i > 15 select i;
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Тип данных result {result.GetType()}");
        }
        /* Привер того что неявный тип var не может быть глобальным
        class MyClass
        {
            public var a = 5;
        }
        static var Foo53()
        {

        }
        static void Bar(var a)
        {

        }
        */
        static int Sum53(int a, int b)
        {
            var result = a + b;
            return result;
        }
        public static void Task53_1()
        {
            var t = Sum53(2, 3);
        }
        /**
         * enum (перечисления)
         */
        public static void Task54()
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keyCode = (int)key;
                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");
                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Вы нажали enter!");
                }
            }
        }
        public static void Task54_1()
        {
            DayOfWeek54 dayOfWeek = DayOfWeek54.Monday;
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek54)));
            Console.WriteLine(dayOfWeek);
            Console.WriteLine((int)dayOfWeek);
            Console.WriteLine((DayOfWeek54)3);
            DayOfWeek54 nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);
        }
        /// <summary>
        /// Получаем следующий день
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        static DayOfWeek54 GetNextDay(DayOfWeek54 day)
        {
            if (day < DayOfWeek54.Sunday)
                return day + 1;
            return DayOfWeek54.Monday;
        }
        public static void Task54_4()
        {
            DayOfWeek54 dayOfWeek;
            byte value = 5;
            if (Enum.IsDefined(typeof(DayOfWeek54), value))
            {
                dayOfWeek = (DayOfWeek54)value; //приводим int к DayOfWeek
            }
            else
            {
                throw new Exception("Invalid DayOfWeek value.");
            }
            Console.WriteLine(dayOfWeek);
        }
        public static void Task54_2()
        {
            var values = Enum.GetValues(typeof(Color));
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
        public static void Task54_3()
        {
            string str = Console.ReadLine();
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true); //ignoreCase: true - игнорирует регистр ввода
            Console.WriteLine(color);
            switch (color)
            {
                case Color.White:
                    break;
                case Color.Red:
                    break;
                case Color.Green:
                    break;
                case Color.Blue:
                    break;
                case Color.Orange:
                    break;
                default:
                    break;
            }
        }
        /**
        * ООП
        * Класс
        * Объект класса (экземпляр)
        */
        public static void Task55()
        {
            Point p = new Point();
            p.x = 4;
            p.y = 2;
            p.color = Color.Orange;
            Point p2 = new Point();
            p2.x = 2;
            p2.y = 6;
            Console.WriteLine($"X: {p.x} | Y: {p.y} | Color: {p.color}");
            Console.WriteLine($"X: {p2.x} | Y: {p2.y}");
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.GetType());
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p.Equals(p2));
        }
        public static void Task55_2()
        {
            var firstStudent = GetStudent();
            Print55(firstStudent);
        }
        /**
         * Вспомогательный метод для Task55_2()
         */
        static Student GetStudent()
        {
            Student student = new Student();
            student.firstName = "Мартин";
            student.midleName = "Игоревич";
            student.lastName = "Дугин";
            student.age = 19;
            student.id = Guid.NewGuid();
            student.group = "ЙЦУКЕН_1";
            return student;
        }
        /**
         * Вспомогательный метод для Task55_2()
         */
        static void Print55(Student student)
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Id: {student.id}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.midleName}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Группа: {student.group}");
        }
        /**
        * ООП
        * методы объекта класса
        */
        public static void Task56()
        {
            var firstStudent = GetStudent();
            firstStudent.Print();
            string fullName = firstStudent.GetFullName();
            Console.WriteLine(fullName);
            Console.WriteLine();
            Console.WriteLine();
            var secondStudent = new Student();
            secondStudent.firstName = "Noname";
            secondStudent.Print();
        }
        public static void Task56_1()
        {
            Console.WriteLine("\t== Car 1 ==");
            var car = new Car56();
            car.PrintSpeed();
            car.DriveForward();
            car.PrintSpeed();
            car.Stop();
            car.PrintSpeed();
            Console.WriteLine("\t== Car 2 ==");
            var car2 = new Car56();
            car2.PrintSpeed();
            car2.DriveBackwaed();
            car2.PrintSpeed();
        }
        /**
        * Модификаторы доступа public и private, для членов класса
        */
        public static void Task57()
        {
            Point57 point = new Point57();
            point.PrintY();
            point.PrintPoint();
            var typeInfo = typeof(Point57).
                GetFields(BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);
            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
            }
        }
        /**
        * Инкапсуляция
        */
        public static void Task58()
        {
            Gun gun = new Gun();
            gun.Shoot();
        }
        /**
        * Конструктор класса
        * 
        * конструктор по умолчанию
        */
        public static void Task59()
        {
            Gun gun = new Gun(isLoaded: true);
            gun.Shoot();
        }
        public static void Task59_2()
        {
            Point59 point = new Point59(5, 3);
            point.Print();
        }
        /**
        * Перегрузка конструкторов класса
        */
        public static void Task60()
        {
            Point59 point = new Point59();
            point.Print();
        }
        public static void Task60_2()
        {
            Student60 student1 = new Student60("Йцукенов", "Йцукен", "Йцукенович", new DateTime(2000, 10, 5));
            Student60 student2 = new Student60(student1);
            student1.SetLastName("########");
            student1.Print();
            Console.WriteLine();
            student2.Print();

        }
        /**
        * this
        */
        public static void Task61()
        {
            Student61 student1 = new Student61("Йцукенов", new DateTime(2000, 10, 5));
            Student61 student2 = new Student61("Qwerty", new DateTime(2000, 10, 5));
            Student61 student3 = new Student61("Йцукенов", "Йцукен", "Йцукенович", new DateTime(2000, 10, 5));
            student1.Print();
            student2.Print();
            student3.Print();
        }
        /**
        * Свойства (Properties)
        * 
        * Автоматические свойства
        */
        public static void Task62()
        {
            Point62 point = new Point62();
            point.SetX(10);
            int x = point.GetX();
            point.Y = 10;
            int y = point.Y;
            point.Z = 1;
            int z = point.Z;
        }
        /**
        * Ключевое слово static
        * 
        * Статические поля класса
        */
        public static void Task63()
        {
            MyClass63 myClass1 = new MyClass63();
            myClass1.SetB(9);
            MyClass63 myClass2 = new MyClass63();
            myClass2.PrintB();
        }
        /**
        * Ключевое слово static
        * 
        * Статические методы класса
        * 
        * Статические свойства класса
        */
        public static void Task64()
        {
            MyClass64 myClass1 = new MyClass64();
            Console.WriteLine(myClass1.ObjectsCount);
            MyClass64 myClass2 = new MyClass64();
            Console.WriteLine(myClass1.GetObjectsCount());
            MyClass64 myClass3 = new MyClass64();
            Console.WriteLine(MyClass64.Counter);
            Console.WriteLine(MyClass64.GetCounter());
        }
        /**
        * Ключевое слово static
        * 
        * Статический конструктор
        */
        public static void Task65()
        {
            MyClass65.Foo();
            new MyClass65();
            new MyClass65();
            new MyClass65();
        }
        public static void Task65_2()
        {
            DbRepository dbRepository = new DbRepository();
            dbRepository.GetData();
        }
        /**
        * Ключевое слово static
        * 
        * Статический класс
        */
        public static void Task66()
        {
            MyClass66.Foo();
            MyClass66.Bar();
        }
        /**
        * Extension методы (методы расширения) (расширяюшие методы)
        */
        public static void Task67()
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();
            DateTime.Now.Print();
            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Tuesday));
        }
        public static void Task67_2()
        {
            Student67 student = new Student67() { FirstName = "Мартин", LastName = "Дугин" };
            string fullName = student.GetFullName();
            Console.WriteLine(fullName);
        }
        /**
        * Частичные типы
        * 
        * partial классы
        * 
        * partial методы
        */
        public static void Task68()
        {
            Person68 person = new Person68("Эгвейн", "ал'Вир");
            person.PrintFullName();
        }
        /**
        * const и readonly
        */
        public static void Task69()
        {
            MyClass69 myClass = new MyClass69(4);
            myClass.Foo();
        }
        public static void Task69_2()
        {
            Car69 car = new Car69(new MyLogger());
            car.Drive();
            car.StartEngine();
            car.StartEngine();
            car.Drive();
        }
        /**
        * синтаксис инициализвции объектов
        */
        public static void Task70()
        {
            Cat cat1 = new Cat();
            cat1.Age = 3;
            cat1.Name = "Барсик";

            Cat cat2 = new Cat
            {
                Age = 3,
                Name = "Барсик"
            };

            Cat cat3 = new Cat("Барсик");
            cat3.Age = 3;

            Cat cat4 = new Cat("Барсик")
            {
                Age = 3,
            };

            Cat cat5 = new Cat("Барсик") // будет Васька
            {
                Age = 3,
                Name = "Васька"
            };
        }
        public static void Task70_2()
        {
            Person70 person1 = new Person70();
            person1.FirstName = "Ранд";
            person1.LastName = "ал'Тор";
            Address address = new Address();
            address.Country = "Андор";
            address.Region = "Двуречье";
            address.City = "Эмондов Луг";
            person1.Address = address;

            Person70 person2 = new Person70
            {
                FirstName = "Ранд",
                LastName = "ал'Тор",
                Address = new Address
                {
                    Country = "Андор",
                    Region = "Двуречье",
                    City = "Эмондов Луг"
                }
            };

            Person70 person3 = new Person70("Ранд", "ал'Тор")
            {
                Address = new Address
                {
                    Country = "Андор",
                    Region = "Двуречье",
                    City = "Эмондов Луг"
                }
            };
        }
        /**
        * Наследование в ООП
        */
        public static void Task71()
        {
            Person71 person = new Person71 { FirstName = "Кей", LastName = "Альтос" };
            person.PrintName();

            Student71 student = new Student71 { FirstName = "Кей", LastName = "Альтос" };
            student.PrintName();
            student.Learn();
            PrintFullName(student);
        }
        public static void Task71_2()
        {
            //Проект Lesson71
        }
        /**
         * Вспомогательный метод для Task71()
         */
        static void PrintFullName(Person71 person)
        {
            Console.WriteLine($"Фамилия: {person.LastName}\t Имя: {person.FirstName}");
        }
        /**
        * наследование, Конструкторы класса и ключевое слово base
        */
        public static void Task72()
        {
            Point3D point3D = new Point3D(3, 6, 8);
            point3D.Print();
        }
        /**
        * приведение типов и наследование 
        * 
        * использование операторов as и is
        */
        public static void Task73()
        {
            object obj = new Point73 { X = 3, Y = 5 };
            Foo73(obj);
            Bar73(obj);
        }
        /**
         * Вспомогательный метод для Task73()
         */
        static void Foo73(object obj)
        {
            Point73 point = obj as Point73;
            if (point != null)
            {
                point.Print();
            }
        }
        /**
         * Вспомогательный метод для Task73()
         */
        static void Bar73(object obj)
        {
            if (obj is Point73 point)
            {
                point.Print();
            }
        }
        /**
        * модификатор доступа protected при наследовании
        */
        public static void Task74()
        {
            A a = new A();
            Console.WriteLine(a.publicField);   //поле доступно
            //Console.WriteLine(a.privateField);   //поле недоступно
            //Console.WriteLine(a.protectedField);   //поле недоступно

            B b = new B();
            Console.WriteLine(b.publicField);   //поле доступно
            //Console.WriteLine(b.privateField);   //поле недоступно
            //Console.WriteLine(b.protectedField);   //поле недоступно
            b.Foo();
        }
        /**
        * полиморфизм
        * 
        * виртуальные методы
        * 
        * virtual
        * 
        * override
        */
        public static void Task75()
        {
            Person75 person = new Person75();
            person.Drive(new SportCar75());
            person.Drive(new Car75());
        }
        /**
        * полиморфизм
        * 
        * абстрактный класс
        * 
        * абстрактный метод
        * 
        * абстрактое свойство
        */
        public static void Task76()
        {
            Player76 player = new Player76();
            Weapon76[] inventory = { new Gun76(), new LaserGun76(), new Bow76() };
            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
        }
        /**
        * интерфейсы и полиморфизм
        * 
        * Интерфейс это кострукция языка программрования C#
        * Интерфейсы должны оперделять поведение и контракт, но не должны содержать реализацию
        * Классы реализуют интерфейс
        * У интерфейса есть множественное наследование - это важное отличие интерфеса от класса или абстрактного класса 
        * Интерфейсы могут наследоваться между собой (один интерфейс может унаследовать несколько разный интерфесов),
        * один определенный класс может унаследовать несколько интерфесов
        * В интерфесе не может быть конструкторов, интерфейс не может содержать поля класса (переменные)
        * Мы не можем создать экземпляр интерфейса
        * Каждая отдельная сущность должна находится в отдельном файле (для классов и интерфейсов разные файлы)
        * У интефесов нет реализации а только "абстрактные" методы (как у астракнтого класса)
        * Интерфейсы иогут содержать свойства. (Свойства это мотоды которые маскируются под поля)
        * Задачей интерфеса является определить контракт азвимодействий между классами
        * С помощью интерфейса мы определяем поведение которое в последствии будет реализовано в каком-то конкретно классе
        * У интерфесов все поля (методы, свойства) по умолчанию имеют модификатор доступа public
        */
        public static void Task77()
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());
        }
        /**
        * Наследование интерфейсов C# 
        * множественное наследование интерфейсов
        */
        public static void Task78()
        {
            //proj Lesson78
        }
        /**
        * Явная реальзация интерфейсов
        */
        public static void Task79()
        {
            MyClass79 myClass = new MyClass79();
            Foo79(myClass);
            Bar79(myClass);
            Console.WriteLine();
            MyOtherClass myOtherClass = new MyOtherClass();
            Foo79(myOtherClass);
            Bar79(myOtherClass);
            Console.WriteLine();
            IFirstInterface firstInterface = myOtherClass;
            firstInterface.Action();
            Console.WriteLine();
            ((IFirstInterface)myOtherClass).Action();
            ((ISecondInterface)myOtherClass).Action();
            Console.WriteLine();
            object obj = new object();
            //((IFirstInterface)obj).Action();  //InvalidCastException
            if (obj is IFirstInterface firstInterface1)
            {
                firstInterface1.Action();
            }
            if (myOtherClass is IFirstInterface firstInterface2)
            {
                firstInterface2.Action();
            }
        }
        /**
         * Вспомогательный метод для Task79()
         */
        static void Foo79(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }
        /**
         * Вспомогательный метод для Task79()
         */
        static void Bar79(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
        /**
        * Реализация интерфейса по умолчанию в C# 8.0
        */
        public static void Task80()
        {
            //proj Lesson80   
        }
        /**
        * Структуры
        */
        public static void Task81()
        {
            //proj Lesson81
        }
        /**
        * boxing and unboxing
        */
        public static void Task82()
        {
            int a = 1;
            a.GetType();
            object b = a; //упаковка
            int c = (int)b; //расспаковка
            //decimal d = (decimal)b; //InvalidCastException
        }
        /**
        * Обобщения (generics)
        */
        public static void Task83()
        {
            double a = 1;
            double b = 5.3;
            Console.WriteLine($"a = {a}\tb = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}\tb = {b}");
            Console.WriteLine("\n");
            string str1 = "Hello";
            string str2 = "World";
            Console.WriteLine($"str1 = {str1}\tstr2 = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"str1 = {str1}\tstr2 = {str2}");
            Console.WriteLine("\n");
            int result = Foo<int>();
            Console.WriteLine(result);
        }
        /**
         * Вспомогательный метод для Task83()
         */
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        /**
         * Вспомогательный метод для Task83()
         */
        static T Foo<T>()
        {
            return default(T);
        }
        public static void Task83_2()
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list[0]);
            list[0] = 2;
            ArrayList arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add("33");
            MyList<int> myList = new MyList<int>();
            myList.Add(5);
            myList.Add(7);
            myList.Add(9);
            myList.Add(45);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
        /**
        * Обобщения (generics)
        */
        public static void Task84()
        {

        }
    }
}