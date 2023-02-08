using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Class1
    {
        private Random random = new Random();

        public Zaim Generate()
        {
            return new Zaim { Фамилия = generateRandomString(random.Next(5, 15)), Имя = generateRandomString(random.Next(5, 15)), Отчество = generateRandomString(random.Next(5, 15)),
                id_Должность = random.Next(1, 6), Дата_Рождения = GenerateDate(new DateTime(1903, 1, 1), new DateTime(2005, 1, 1)), id_Пол = random.Next(1, 3), Сумма_займа = random.Next(5, 15) };

        }
        public string generateRandomString (int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string GenerateDate(DateTime start, DateTime end)
        {
            int range = (end - start).Days;
            int randDays = random.Next(0, range);
            return Convert.ToString(start.AddDays(randDays));
            
        }

    }
}

