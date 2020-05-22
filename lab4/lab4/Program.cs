using System;
using System.IO;

namespace lab4
{
    /// <summary>
    /// Класс для реализации поставленной задачи
    /// </summary>
    class Program
    {
        /// <summary>
        /// Общий интерфейс локализатора
        /// </summary>
        public interface IAbstractLocalisator
        {
            /// <summary>
            /// Функция для возврата настроек нужных определенному типу открываемых файлов
            /// </summary>
            /// <returns>изменяемые настройки</returns>
            IAbstractSettings GetSettings();
        }
        /// <summary>
        /// Класс китайского локализатора
        /// </summary>
        class ChinaLocalisator : IAbstractLocalisator
        {
            /// <summary>
            /// Функция получения настроек 
            /// </summary>
            /// <returns>Настройки локализации под Китай</returns>
            public IAbstractSettings GetSettings()
            {
                return new ChinaSettings();
            }
        }
        /// <summary>
        /// Класс немецкого локализатора
        /// </summary>
        class GermanLocalisator : IAbstractLocalisator
        {
            /// <summary>
            /// Функция получения настроек
            /// </summary>
            /// <returns>Настройки локализации под Германию</returns>
            public IAbstractSettings GetSettings()
            {
                return new GermanySettings();
            }
        }
        /// <summary>
        /// Класс русского локализатора
        /// </summary>
        class RussianLocalisator : IAbstractLocalisator
        {
            /// <summary>
            /// Функция получения настроек
            /// </summary>
            /// <returns>Настройки Настройки локализации под Россию</returns>
            public IAbstractSettings GetSettings()
            {
                return new RussiaSettings();
            }
        }
        /// <summary>
        /// Интерфейс настроек
        /// </summary>
        public interface IAbstractSettings
        {
            /// <summary>
            /// Вывод названия страны
            /// </summary>
            /// <returns>*Название страны*</returns>
            string PrintCountry();
            /// <summary>
            /// Изменение языка
            /// </summary>
            /// <returns>Язык изменён</returns>
            string SetLanguage();
            /// <summary>
            /// Изменение часового пояса
            /// </summary>
            /// <returns>Часовой пояс изменён</returns>
            string SetTimeZone();
            /// <summary>
            /// Изменение раскладки клавиатуры по-умолчанию
            /// </summary>
            /// <returns>Раскладка клавиатуры изменена</returns>
            string SetDefaultLayout();
            /// <summary>
            /// Изменение валюты по-умолчанию
            /// </summary>
            /// <returns>Установлена валюта *валюта нейм*</returns>
            string SetCurrencyType();
            /// <summary>
            /// Изменение доп настройки 1
            /// </summary>
            /// <returns>Доп настройка 1 изменена</returns>
            string SetExtraSetting1();
            /// <summary>
            /// Изменение доп настройки 2
            /// </summary>
            /// <returns>Доп настройка 2 изменена</returns>
            string SetExtraSetting2();
            /// <summary>
            /// Изменение доп настройки 3
            /// </summary>
            /// <returns>Доп настройка 3 изменена</returns>
            string SetExtraSetting3();
            /// <summary>
            /// Изменение доп настройки 4
            /// </summary>
            /// <returns>Доп настройка 4 изменена</returns>
            string SetExtraSetting4();
            /// <summary>
            /// Изменение доп настройки 5
            /// </summary>
            /// <returns>Доп настройка 5 изменена</returns>
            string SetExtraSetting5();
            /// <summary>
            /// Изменение доп настройки 6
            /// </summary>
            /// <returns>Доп настройка 6 изменена</returns>
            string SetExtraSetting6();

        }
        /// <summary>
        /// Настройки для Китая
        /// </summary>
        class ChinaSettings : IAbstractSettings
        {
            /// <summary>
            /// Вывод названия страны
            /// </summary>
            /// <returns>China</returns>
            public string PrintCountry()
            {
                return "China";
            }
            /// <summary>
            /// Изменение языка
            /// </summary>
            /// <returns>Language has been set to Mandarin</returns>
            public string SetLanguage()
            {
                return "Language has been set to Mandarin";
            }
            /// <summary>
            /// Изменение часового пояса
            /// </summary>
            /// <returns>Time zone has been set to China Standard Time (CST)</returns>
            public string SetTimeZone()
            {
                return "Time zone has been set to China Standard Time (CST)";
            }
            /// <summary>
            /// Изменение раскладки клавиатуры по-умолчанию
            /// </summary>
            /// <returns>The keyboard layout is now chinese</returns>
            public string SetDefaultLayout()
            {
                return "The keyboard layout is now chinese";
            }
            /// <summary>
            /// Изменение валюты по-умолчанию
            /// </summary>
            /// <returns>Currency is now yuan</returns>
            public string SetCurrencyType()
            {
                return "Currency is now yuan";
            }
            /// <summary>
            /// Изменение доп настройки 1
            /// </summary>
            /// <returns>Extra setting number 1 has been set</returns>
            public string SetExtraSetting1()
            {
                return "Extra setting number 1 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 2
            /// </summary>
            /// <returns>Extra setting number 2 has been set</returns>
            public string SetExtraSetting2()
            {
                return "Extra setting number 2 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 3
            /// </summary>
            /// <returns>Extra setting number 3 has been set</returns>
            public string SetExtraSetting3()
            {
                return "Extra setting number 3 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 4
            /// </summary>
            /// <returns>Extra setting number 4 has been set</returns>
            public string SetExtraSetting4()
            {
                return "Extra setting number 4 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 5
            /// </summary>
            /// <returns>Extra setting number 5 has been set</returns>
            public string SetExtraSetting5()
            {
                return "Extra setting number 5 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 6
            /// </summary>
            /// <returns>Extra setting number 6 has been set</returns>
            public string SetExtraSetting6()
            {
                return "Extra setting number 6 has been set";
            }
        }
        /// <summary>
        /// Настройки для Германии
        /// </summary>
        class GermanySettings : IAbstractSettings
        {
            /// <summary>
            /// Вывод названия страны
            /// </summary>
            /// <returns>Germany</returns>
            public string PrintCountry()
            {
                return "Germany";
            }
            /// <summary>
            /// Изменение языка
            /// </summary>
            /// <returns>Language has been set to German</returns>
            public string SetLanguage()
            {
                return "Language has been set to German";
            }
            /// <summary>
            /// Изменение часового пояса
            /// </summary>
            /// <returns>Time zone has been set to Central European Standard Time (CET)</returns>
            public string SetTimeZone()
            {
                return "Time zone has been set to Central European Standard Time (CET)";
            }
            /// <summary>
            /// Изменение раскладки клавиатуры по-умолчанию
            /// </summary>
            /// <returns>The keyboard layout is now english</returns>
            public string SetDefaultLayout()
            {
                return "The keyboard layout is now english";
            }
            /// <summary>
            /// Изменение валюты по-умолчанию
            /// </summary>
            /// <returns>Currency is now euro</returns>
            public string SetCurrencyType()
            {
                return "Currency is now euro";
            }
            /// <summary>
            /// Изменение доп настройки 1
            /// </summary>
            /// <returns>Extra setting number 1 has been set</returns>
            public string SetExtraSetting1()
            {
                return "Extra setting number 1 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 2
            /// </summary>
            /// <returns>Extra setting number 2 has been set</returns>
            public string SetExtraSetting2()
            {
                return "Extra setting number 2 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 3
            /// </summary>
            /// <returns>Extra setting number 3 has been set</returns>
            public string SetExtraSetting3()
            {
                return "Extra setting number 3 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 4
            /// </summary>
            /// <returns>Extra setting number 4 has been set</returns>
            public string SetExtraSetting4()
            {
                return "Extra setting number 4 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 5
            /// </summary>
            /// <returns>Extra setting number 5 has been set</returns>
            public string SetExtraSetting5()
            {
                return "Extra setting number 5 has been set";
            }
            /// <summary>
            /// Изменение доп настройки 6
            /// </summary>
            /// <returns>Extra setting number 6 has been set</returns>
            public string SetExtraSetting6()
            {
                return "Extra setting number 6 has been set";
            }
        }

        /// <summary>
        /// Настройки для России
        /// </summary>
        class RussiaSettings:IAbstractSettings
        {
            /// <summary>
            /// Вывод названия страны
            /// </summary>
            /// <returns>Россия</returns>
            public string PrintCountry()
            {
                return "Россия";
            }
            /// <summary>
            /// Изменение языка
            /// </summary>
            /// <returns>Language has been set to German</returns>
            public string SetLanguage()
            {
                return "Язык был изменён на русский";
            }
            /// <summary>
            /// Изменение часового пояса
            /// </summary>
            /// <returns>Часовой пояс был измененён на GMT+3 (московское время)</returns>
            public string SetTimeZone()
            {
                return "Часовой пояс был измененён на GMT+3 (московское время)";
            }
            /// <summary>
            /// Изменение раскладки клавиатуры по-умолчанию
            /// </summary>
            /// <returns>Раскладка клавиатуры изменена на русскую</returns>
            public string SetDefaultLayout()
            {
                return "Раскладка клавиатуры изменена на русскую";
            }
            /// <summary>
            /// Изменение валюты по-умолчанию
            /// </summary>
            /// <returns>Валюта изменена на рубль</returns>
            public string SetCurrencyType()
            {
                return "Валюта изменена на рубль";
            }
            /// <summary>
            /// Изменение доп настройки 1
            /// </summary>
            /// <returns>Доп настройка 1 была изменена</returns>
            public string SetExtraSetting1()
            {
                return "Доп настройка 1 была изменена";
            }
            /// <summary>
            /// Изменение доп настройки 2
            /// </summary>
            /// <returns>Доп настройка 2 была изменена</returns>
            public string SetExtraSetting2()
            {
                return "Доп настройка 2 была изменена";
            }
            /// <summary>
            /// Изменение доп настройки 3
            /// </summary>
            /// <returns>Доп настройка 3 была изменена</returns>
            public string SetExtraSetting3()
            {
                return "Доп настройка 3 была изменена";
            }
            /// <summary>
            /// Изменение доп настройки 4
            /// </summary>
            /// <returns>Доп настройка 4 была изменена</returns>
            public string SetExtraSetting4()
            {
                return "Доп настройка 4 была изменена";
            }
            /// <summary>
            /// Изменение доп настройки 5
            /// </summary>
            /// <returns>Доп настройка 5 была изменена</returns>
            public string SetExtraSetting5()
            {
                return "Доп настройка 5 была изменена";
            }
            /// <summary>
            /// Изменение доп настройки 6
            /// </summary>
            /// <returns>EДоп настройка 6 была изменена</returns>
            public string SetExtraSetting6()
            {
                return "Доп настройка 6 была изменена";
            }
        }

        /// <summary>
        /// Класс клиент
        /// </summary>
        class Client
        {
            /// <summary>
            /// Вывод настроек для конкретной страны, в зависимости от страны клиента
            /// </summary>
            public void China()
            {
                ClientLocalisation(new ChinaLocalisator());
                Console.WriteLine();
            }

            public void Germany()
            {
                ClientLocalisation(new GermanLocalisator());
                Console.WriteLine();
            }

            public void Russia()
            {
                ClientLocalisation(new RussianLocalisator());
                Console.WriteLine();
            }
            /// <summary>
            /// Вывод на экран страны и настроек
            /// </summary>
            /// <param name="localisator для обращения к функциям интерфейса"></param>
            public void ClientLocalisation(IAbstractLocalisator localisator)
            {
                var Settings = localisator.GetSettings();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Settings:");
                Console.WriteLine(Settings.PrintCountry());
                Console.WriteLine(Settings.SetLanguage());
                Console.WriteLine(Settings.SetTimeZone());
                Console.WriteLine(Settings.SetDefaultLayout());
                Console.WriteLine(Settings.SetCurrencyType());
                Console.WriteLine(Settings.SetExtraSetting1());
                Console.WriteLine(Settings.SetExtraSetting2());
                Console.WriteLine(Settings.SetExtraSetting3());
                Console.WriteLine(Settings.SetExtraSetting4());
                Console.WriteLine(Settings.SetExtraSetting5());
                Console.WriteLine(Settings.SetExtraSetting6());
            }
        }
        
        
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            string country;
            Console.WriteLine("Введите название страны:");
            country = Console.ReadLine();
               
            switch (country)
            {
                case "Китай":
                    new Client().China();
                    break;
                case "Германия":
                    new Client().Germany();
                    break;
                case "Россия":
                    new Client().Russia();
                    break;
                case "China":
                    new Client().China();
                    break;
                case "Germany":
                    new Client().Germany();
                    break;
                case "Russia":
                    new Client().Russia();
                    break;
                default:
                    Console.WriteLine("Incorrect name of the country. Enter China, Germany or Russia.");
                    break;
            }
            Console.ReadLine();
            
        }
    }
}
