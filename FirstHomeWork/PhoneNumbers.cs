using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork
{
    class PhoneNumbers
    {
        public enum Grade
        {
            colleague,
            friend,
            kinsman,
            important
        }

        private string number;
        private string name;
        private string info;
        private Grade grade;

        public PhoneNumbers(string number, string name, string info, Grade grade)
        {
            this.number = number;
            this.name = name;
            this.info = info;
            this.grade = grade;
        }

        public string Get()
        {
            return $"{number}${name}${info}${(int)grade}";
        }
        public override string ToString()
        {
            return $"Номер телефона: {number}\nИмя контакта: {name}\nИнформация о контакте: {info}\nКонтакт для вас является: {grade}";
        }
    }
}
