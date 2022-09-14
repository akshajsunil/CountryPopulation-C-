using System;
namespace collection{
    class Program{
        static void Main(string[] args){
           string filePath = "C:/Users/ASUS/Downloads/population-data.csv";
           CsvReader reader = new CsvReader(filePath);
           Country [] countries = reader.ReadFirstNCountries(10);
           

           foreach(Country i in countries){
            Console.WriteLine($"{PopulationFormatter.FormatPopulation(i.Population).PadLeft(15)} : {i.Name}");
           }
 


        }
    }
}
