using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string type, description;
                Console.WriteLine("Введите тип ос (варианты: home, pro, corp)");
                type = Console.ReadLine();
                switch (type)
                {
                    case "home":
                        description = new OsOptionsDirector(new HomeOsOptionsBuilder()).buildAndGet().describe();
                        break;
                    case "pro":
                        description = new OsOptionsDirector(new ProOsOptionsBuilder()).buildAndGet().describe();
                        break;
                    case "corp":
                        description = new OsOptionsDirector(new CorpOsOptionsBuilder()).buildAndGet().describe();
                        break;
                    default:
                        Console.WriteLine("Введен не существующий тип ос");
                        return;
                }
                Console.WriteLine(description);
            }
            catch
            {
                Console.WriteLine("Wrong file name!");
            }
        }
    }
    /// <summary>
    /// Настройки ОС
    /// </summary>
    class OsOptions 
    {
        /// <summary>
        /// Тип ОС
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// Тема ОС
        /// </summary>
        public bool blackTheme { get; set; }
        /// <summary>
        /// Настройка А ОС
        /// </summary>
        public string a { get; set; }
        /// <summary>
        /// Настройка B ОС
        /// </summary>
        public string b { get; set; }
        /// <summary>
        /// Настройка C ОС
        /// </summary>
        public string c { get; set; }
        /// <summary>
        /// Настройка D ОС
        /// </summary>
        public string d { get; set; }
        /// <summary>
        /// Настройка E ОС
        /// </summary>
        public string e { get; set; }
        /// <summary>
        /// Настройка F ОС
        /// </summary>
        public string f { get; set; }
        /// <summary>
        /// Настройка G ОС
        /// </summary>
        public string g { get; set; }
        /// <summary>
        /// Настройка H ОС
        /// </summary>
        public string h { get; set; }
        /// <summary>
        /// Конструктор опций
        /// </summary>
        public OsOptions() { }
        public string describe()
        {
            return $"Опции ОС:\n" +
                $"Тип: {type}\n" +
                $"Темная тема {blackTheme}\n" +
                $"Настройка А: {a}\n" +
                $"Настройка B: {b}\n" +
                $"Настройка C: {c}\n" +
                $"Настройка D: {d}\n" +
                $"Настройка E: {e}\n" +
                $"Настройка F: {f}\n" +
                $"Настройка G: {g}\nv" +
                $"Настройка H: {h}";
        }
    }
    /// <summary>
    /// Управляюший строителями настроек ОС
    /// </summary>
    class OsOptionsDirector
    {
        /// <summary>
        /// Строитель настроек ос
        /// </summary>
        OsOptionsBuilder builder;
        /// <summary>
        /// Создание управляющего
        /// </summary>
        /// <param builder="строитель настроек"></param>
        public OsOptionsDirector(OsOptionsBuilder builder)
        {
            this.builder = builder;
        }
        /// <summary>
        /// Созадние и возврашение настроек через строителя
        /// </summary>
        /// <returns>Настройки ос</returns>
        public OsOptions buildAndGet()
        {
            builder.setType();
            builder.setTheme();
            builder.setsettingA();
            builder.setsettingB();
            builder.setsettingC();
            builder.setsettingD();
            builder.setsettingE();
            builder.setsettingF();
            builder.setsettingG();
            builder.setsettingH();
            return builder.getOptions();
        }

    }
    /// <summary>
    /// Общий интерфейс строителя настроек
    /// </summary>
    abstract class OsOptionsBuilder
    {
        /// <summary>
        /// Объект настроек
        /// </summary>
        protected OsOptions obj;
        /// <summary>
        /// Конструктор строителя
        /// </summary>
        protected OsOptionsBuilder()
        {
            obj = new OsOptions();
        }
        /// <summary>
        /// Функция для установки типа ОС
        /// </summary>
        abstract public void setType();
        /// <summary>
        /// Функция для установки темы ОС
        /// </summary>
        abstract public void setTheme();
        /// <summary>
        /// Функция для установки настройки А ОС
        /// </summary>
        abstract public void setsettingA();
        /// <summary>
        /// Функция для установки настройки B ОС
        /// </summary>
        abstract public void setsettingB();
        /// <summary>
        /// Функция для установки настройки C ОС
        /// </summary>
        abstract public void setsettingC();
        /// <summary>
        /// Функция для установки настройки D ОС
        /// </summary>
        abstract public void setsettingD();
        /// <summary>
        /// Функция для установки настройки F ОС
        /// </summary>
        abstract public void setsettingE();
        /// <summary>
        /// Функция для установки настройки E ОС
        /// </summary>
        abstract public void setsettingF();
        /// <summary>
        /// Функция для установки настройки G ОС
        /// </summary>
        abstract public void setsettingG();
        /// <summary>
        /// Функция для установки настройки H ОС
        /// </summary>
        abstract public void setsettingH();
        /// <summary>
        /// Функция для возврата построенных настроек
        /// </summary>
        /// <returns>Текущие настройки</returns>

        public OsOptions getOptions() { return obj; }
    }
    /// <summary>
    /// Класс настроек для Домашней версии ОС
    /// </summary>
    class HomeOsOptionsBuilder : OsOptionsBuilder
    {
        public HomeOsOptionsBuilder() : base() { }

        /// <summary>
        /// Функция для установки домашнего типа ОС
        /// </summary>
        override public void setType() { obj.type = "home"; }
        /// <summary>
        /// Функция для установки темы для домашней ОС
        /// </summary>
        override public void setTheme() { obj.blackTheme = false; }
        /// <summary>
        /// Функция для установки настройки A для домашней ОС
        /// </summary>
        override public void setsettingA() { obj.a = "home a"; }
        /// <summary>
        /// Функция для установки настройки B для домашней ОС
        /// </summary>
        override public void setsettingB() { obj.b = "home b"; }
        /// <summary>
        /// Функция для установки настройки C для домашней ОС
        /// </summary>
        override public void setsettingC() { obj.c = "home c"; }
        /// <summary>
        /// Функция для установки настройки D для домашней ОС
        /// </summary>
        override public void setsettingD() { obj.d = "home d"; }
        /// <summary>
        /// Функция для установки настройки E для домашней ОС
        /// </summary>
        override public void setsettingE() { obj.e = "home e"; }
        /// <summary>
        /// Функция для установки настройки F для домашней ОС
        /// </summary>
        override public void setsettingF() { obj.f = "home f"; }
        /// <summary>
        /// Функция для установки настройки G для домашней ОС
        /// </summary>
        override public void setsettingG() { obj.g = "home g"; }
        /// <summary>
        /// Функция для установки настройки H для домашней ОС
        /// </summary>
        override public void setsettingH() { obj.h = "home h"; }
    }
    /// <summary>
    /// Класс настроек для профессианальной версии ОС
    /// </summary>
    class ProOsOptionsBuilder : OsOptionsBuilder
    {
        public ProOsOptionsBuilder() : base() { }

        /// <summary>
        /// Функция для установки профессианального типа ОС
        /// </summary>
        override public void setType() { obj.type = "pro"; }
        /// <summary>
        /// Функция для установки темы для профессианальной ОС
        /// </summary>
        override public void setTheme() { obj.blackTheme = true; }
        /// <summary>
        /// Функция для установки настройки A для профессианальной ОС
        /// </summary>
        override public void setsettingA() { obj.a = "pro a"; }
        /// <summary>
        /// Функция для установки настройки B для профессианальной ОС
        /// </summary>
        override public void setsettingB() { obj.b = "pro b"; }
        /// <summary>
        /// Функция для установки настройки C для профессианальной ОС
        /// </summary>
        override public void setsettingC() { obj.c = "pro c"; }
        /// <summary>
        /// Функция для установки настройки D для профессианальной ОС
        /// </summary>
        override public void setsettingD() { obj.d = "pro d"; }
        /// <summary>
        /// Функция для установки настройки E для профессианальной ОС
        /// </summary>
        override public void setsettingE() { obj.e = "pro e"; }
        /// <summary>
        /// Функция для установки настройки F для профессианальной ОС
        /// </summary>
        override public void setsettingF() { obj.f = "pro f"; }
        /// <summary>
        /// Функция для установки настройки G для профессианальной ОС
        /// </summary>
        override public void setsettingG() { obj.g = "pro g"; }
        /// <summary>
        /// Функция для установки настройки H для профессианальной ОС
        /// </summary>
        override public void setsettingH() { obj.h = "pro h"; }
    }
    /// <summary>
    /// Класс настроек для корпоративной версии ОС
    /// </summary>
    class CorpOsOptionsBuilder : OsOptionsBuilder
    {
        public CorpOsOptionsBuilder() : base() { }

        /// <summary>
        /// Функция для установки корпоративного типа ОС
        /// </summary>
        override public void setType() { obj.type = "corp"; }
        /// <summary>
        /// Функция для установки темы для корпоративной ОС
        /// </summary>
        override public void setTheme() { obj.blackTheme = true; }
        /// <summary>
        /// Функция для установки настройки A для корпоративной ОС
        /// </summary>
        override public void setsettingA() { obj.a = "corp a"; }
        /// <summary>
        /// Функция для установки настройки B для корпоративной ОС
        /// </summary>
        override public void setsettingB() { obj.b = "corp b"; }
        /// <summary>
        /// Функция для установки настройки C для корпоративной ОС
        /// </summary>
        override public void setsettingC() { obj.c = "corp c"; }
        /// <summary>
        /// Функция для установки настройки D для корпоративной ОС
        /// </summary>
        override public void setsettingD() { obj.d = "corp d"; }
        /// <summary>
        /// Функция для установки настройки E для корпоративной ОС
        /// </summary>
        override public void setsettingE() { obj.e = "corp e"; }
        /// <summary>
        /// Функция для установки настройки F для корпоративной ОС
        /// </summary>
        override public void setsettingF() { obj.f = "corp f"; }
        /// <summary>
        /// Функция для установки настройки G для корпоративной ОС
        /// </summary>
        override public void setsettingG() { obj.g = "corp g"; }
        /// <summary>
        /// Функция для установки настройки H для корпоративной ОС
        /// </summary>
        override public void setsettingH() { obj.h = "corp h"; }
    }
}
