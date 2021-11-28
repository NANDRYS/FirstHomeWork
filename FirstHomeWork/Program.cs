using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FirstHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhoneNumbers> numbers = DataWorker.LoadList();
            PhoneNumbersManager phmanager = new PhoneNumbersManager();
            int action;

            PhoneNumbers Pnum1 = new PhoneNumbers("99999", "Катя", "Шлюха", PhoneNumbers.Grade.important);
            PhoneNumbers Pnum2 = new PhoneNumbers("88888", "Анжелла", "Шлюха но получше", PhoneNumbers.Grade.friend);

            phmanager.AddPhoneNumbers(Pnum1);
            phmanager.AddPhoneNumbers(Pnum2);
            DataWorker.SaveList(phmanager.Get());
            while (true)
            {
                Console.Clear();
                phmanager.PrintPhoneList();

                Console.WriteLine("Меню контактов");
                Console.WriteLine("1. Добавить контакт");
                Console.WriteLine("2. Удалить контакт");
                Console.WriteLine("3. Изменить контакт");
                Console.WriteLine("4. Сохраниь контакт");
                Console.WriteLine("0. Выход");
                Console.Write("Введите действие: ");
                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.Write("Введите номер телефона: ");
                            string number = Console.ReadLine();
                            Console.Write("Введите имя контакта: ");
                            string name = Console.ReadLine();
                            Console.Write("Введите информацию о контакте: ");
                            string info = Console.ReadLine(); 
                            Console.Write("Важность контакта/кем является контакт\n0 - коллега,\n1 - друг,\n2 - родственник,\n3 - важный контакт: ");
                            PhoneNumbers.Grade grade = (PhoneNumbers.Grade)int.Parse(Console.ReadLine());

                            PhoneNumbers pnum = new PhoneNumbers(number, name, info, grade);

                            phmanager.AddPhoneNumbers(pnum);
                        }
                        break;
                    case 2:
                        {
                            try
                            {
                                Console.Write("Введите номера контакта : ");
                                int index = int.Parse(Console.ReadLine());

                                Console.WriteLine(phmanager.DeletePhoneNumbers(index - 1));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }
                        break;
                    case 3:
                        {
                            try
                            {
                                Console.Write("Введите номера контакта : ");
                                int index = int.Parse(Console.ReadLine());

                                Console.WriteLine(phmanager.DeletePhoneNumbers(index - 1));
                                Console.Write("Введите номер телефона: ");
                                string number = Console.ReadLine();
                                Console.Write("Введите имя контакта: ");
                                string name = Console.ReadLine();
                                Console.Write("Введите информацию о контакте: ");
                                string info = Console.ReadLine();
                                Console.Write("Важность контакта/кем является контакт\n0 - коллега,\n1 - друг,\n2 - родственник,\n3 - важный контакт: ");
                                PhoneNumbers.Grade grade = (PhoneNumbers.Grade)int.Parse(Console.ReadLine());

                                PhoneNumbers pnum = new PhoneNumbers(number, name, info, grade);

                                phmanager.AddPhoneNumbers(pnum);

                                Console.WriteLine("Замена выполнена");

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }
                        break;
                    case 4:
                        {
                            try
                            {
                                Console.Write("Введите номера контакта : ");
                                int index = int.Parse(Console.ReadLine());

                                Console.WriteLine(phmanager.SaveListNumbders(index - 1));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }
                        break;
                    case 0:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                            Console.WriteLine("Такого действия нету!");
                        break;
                }
            }
        }
    }
}
