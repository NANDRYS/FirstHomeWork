using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FirstHomeWork
{
    class PhoneNumbersManager
    {
        private List<PhoneNumbers> phoneNumbers;
        private const string NameNumbers = "PhoneListNumbers.txt";

        public PhoneNumbersManager()
        {
            phoneNumbers = new List<PhoneNumbers>();
        }

        public void AddPhoneNumbers(PhoneNumbers phoneNumber)
        {
            phoneNumbers.Add(phoneNumber);
        }

        public bool ReplacePhoneNumbers(int index, PhoneNumbers phoneNumber)
        {
            if(index >= 0 && index <= phoneNumbers.Count - 1)
            {
                phoneNumbers[index] = phoneNumber;
                return true;
            }
            else
            {
                throw new Exception("Такого контакта не существует");
            }

        }

        public bool DeletePhoneNumbers(int index)
        {
            if (index >= 0 && index <= phoneNumbers.Count - 1)
            {
                phoneNumbers.RemoveAt(index);
                return true;
            }
            else
            {
                throw new Exception("такого контакта не существует");
            }
        }

        public void PrintPhoneList()
        {
            if(phoneNumbers.Count == 0)
            {
                Console.WriteLine("\nЧто ж, список контактов пуст :(");
                Console.WriteLine("======");
            }
            else 
            { 
                for (int i = 0; i < phoneNumbers.Count; i++)
                {
                    Console.WriteLine($"Котнтакт номер №{i + 1}");
                    Console.WriteLine(phoneNumbers[i]);
                    Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+\n");
                }
            }
        }

        public bool SaveListNumbders(int index)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(NameNumbers, false, System.Text.Encoding.Default))
                    
                {
                    if (index >= 0 && index <= phoneNumbers.Count - 1)
                    {
                        sw.WriteLine(phoneNumbers[index]);
                        Console.WriteLine("Запись выполнена");
                    }
                    else
                    {
                        throw new Exception("Такого контакта не существует");
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<PhoneNumbers> Get()
        {
            return phoneNumbers;
        }
    }
    
}
