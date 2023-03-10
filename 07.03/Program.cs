using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03
{
    class Firm
    {
        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public string BusinessProfile { get; set; }
        public string CEOFullName { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Firm[] firms = new Firm[]
            {
            new Firm
            {
                Name = "Food",
                FoundedDate = new DateTime(2000, 1, 1),
                BusinessProfile = "Food",
                CEOFullName = "John Pop",
                NumberOfEmployees = 50,
                Address = "123 St."
            },
            new Firm
            {
                Name = "IT",
                FoundedDate = new DateTime(2010, 5, 1),
                BusinessProfile = "IT",
                CEOFullName = "John han",
                NumberOfEmployees = 200,
                Address = "456 St."
            },
            new Firm
            {
                Name = "Marketing",
                FoundedDate = new DateTime(2004, 1, 21),
                BusinessProfile = "Marketing",
                CEOFullName = "John Vos",
                NumberOfEmployees = 75,
                Address = "789 St."
            }
            };

            // Получить информацию обо всех фирмах
            var allFirms = firms.ToList();
            Console.WriteLine("Все фирмы:");
            foreach (var firm in allFirms)
            {
                Console.WriteLine($"{firm.Name} (основана {firm.FoundedDate.ToShortDateString()}, бизнес-профиль: {firm.BusinessProfile}, директор: {firm.CEOFullName}, сотрудников: {firm.NumberOfEmployees}, адрес: {firm.Address})");
            }
            Console.WriteLine();

            // Получить фирмы, у которых в названии есть слово Food
            var foodFirms = firms.Where(f => f.Name.Contains("Food")).ToList();
            Console.WriteLine("Фирмы с названием, содержащим слово 'Food':");
            foreach (var firm in foodFirms)
            {
                Console.WriteLine($"{firm.Name} (основана {firm.FoundedDate.ToShortDateString()}, бизнес-профиль: {firm.BusinessProfile}, директор: {firm.CEOFullName}, сотрудников: {firm.NumberOfEmployees}, адрес: {firm.Address})");
            }
            Console.WriteLine();

            // Получить фирмы, которые работают в области маркетинга
            var marketingFirms = firms.Where(f => f.BusinessProfile == "Marketing").ToList();
            Console.WriteLine("Фирмы в области маркетинга:");
            foreach (var firm in marketingFirms)
            {
                Console.WriteLine($"{firm.Name} (основана {firm.FoundedDate.ToShortDateString()}, бизнес-профиль: {firm.BusinessProfile}, директор: {firm.CEOFullName}, сотрудников: {firm.NumberOfEmployees}, адрес: {firm.Address})");
            }
            Console.WriteLine();

            // Получить фирмы, которые работают в области маркетинга или IT
            var marketingAndITFirms = firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT").ToList();
            Console.WriteLine("Фирмы в области маркетинга или IT:");
            foreach (var firm in marketingAndITFirms)
            {
                Console.WriteLine($"{firm.Name} (основана {firm.FoundedDate.ToShortDateString()}, бизнес-профиль: {firm.BusinessProfile}, директор: {firm.CEOFullName}, сотрудников: {firm.NumberOfEmployees}, адрес: {firm.Address})");

            }
            Console.WriteLine();

            // фирмы с количеством сотрудников, большем 100
            var largeFirms = firms.Where(f => f.NumberOfEmployees > 100).ToList();
            Console.WriteLine("Фирмы с более чем 100 сотрудниками:");
            foreach (var firm in largeFirms)
            {
                Console.WriteLine($"{firm.Name} (основана {firm.FoundedDate.ToShortDateString()}, бизнес-профиль: {firm.BusinessProfile}, директор: {firm.CEOFullName}, сотрудников: {firm.NumberOfEmployees}, адрес: {firm.Address})");
            }
            Console.WriteLine();

            // Получить фирмы с количеством сотрудников в диапазоне от 100 до 300
            var mediumFirms = firms.Where(f => f.NumberOfEmployees >= 100 && f.NumberOfEmployees <= 300).ToList();
            Console.WriteLine("Фирмы с 100-300 сотрудниками:");
            foreach (var firm in mediumFirms)
            {
                Console.WriteLine($"{firm.Name} (основана {firm.FoundedDate.ToShortDateString()}, бизнес-профиль: {firm.BusinessProfile}, директор: {firm.CEOFullName}, сотрудников: {firm.NumberOfEmployees}, адрес: {firm.Address})");
            }
            Console.WriteLine();
        }
    }
}
