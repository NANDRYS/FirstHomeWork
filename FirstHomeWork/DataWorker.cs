using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstHomeWork
{
    class DataWorker
    {
        
        static public List<PhoneNumbers> LoadList()
        {
            StreamReader reader = new StreamReader("Save.txt");
            List<PhoneNumbers> numbers = new List<PhoneNumbers>();
            int count = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string inputData = reader.ReadLine();
                numbers.Add(new PhoneNumbers(inputData.Split('$')[0], inputData.Split('$')[1], inputData.Split('$')[2], (PhoneNumbers.Grade)Convert.ToInt32(inputData.Split('$')[3])));
                
            }
            reader.Dispose();
            return numbers;
        }

        static public void SaveList(List<PhoneNumbers> numbers)
        {
            StreamWriter writer = new StreamWriter("Save.txt");
            int count = numbers.Count;
            
            writer.WriteLine(count.ToString());
            for (int i = 0; i < count; i++)
            {
                writer.WriteLine(numbers[i].Get());                
            }
            writer.Dispose();
        }
    }
}
