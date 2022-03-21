using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

var fileContent = await File.ReadAllTextAsync("data.json");

var cars = JsonSerializer.Deserialize<List<CarData>>(fileContent);

// Print all cars with at least 4 doors
//var carsWithAtLeastFourDoors = cars.Where(c => c.NumberOfDoors > 4);

//foreach (var car in carsWithAtLeastFourDoors)
//{
//    Console.WriteLine($"The car {car.Model} has {car.NumberOfDoors} doors");
//}

// Print all Mazda cars with at least 4 doors

//var mazdaWithAtLeastFourDoors = cars.Where(c => c.Make == "Mazda"); // && c.NumberOfDoors >= 4);
//mazdaWithAtLeastFourDoors = cars.Where(c => c.NumberOfDoors >= 4);

//foreach (var mazda in mazdaWithAtLeastFourDoors)
//{
//    Console.WriteLine($"Mazda {mazda.Year} year has {mazda.NumberOfDoors} doors");
//}


// Print make + Model for all Makes that start with "M"

//var carsStartMakeWithM = cars.Where(car => car.Make.StartsWith("M"));

//foreach (var car in carsStartMakeWithM)
//{
//    Console.WriteLine($"{car.Make} - {car.Model} starts with 'M'");
//}


//cars.Where(c => c.Make.StartsWith("M"))
//    .Select(c => $"{c.Make} {c.Model}")
//    .ToList()
//    .ForEach(c => Console.WriteLine(c));


// Display a list of the 10 most powerfull cars (in terms of hp) 

//cars.OrderByDescending(c => c.HP)
//    .Take(10)
//    .Select(c => $"{c.Make} {c.HP}")
//    .ToList()
//    .ForEach(c => Console.WriteLine(c));


// Display the number of models per Make that appeared after 1995
// Makes should be displayed with a number of zero if there are no models after 2010.

//cars.GroupBy(c => c.Make)
//    .OrderBy(car => car.Key)
//    //.Select(c => new { c.Key, NumberOfModels = c.Where(c => c.Year > 2010).Count() })
//    .Select(c => new { c.Key, NumberOfModels = c.Count(c => c.Year > 2010)})
//    .ToList()
//    .ForEach(c => Console.WriteLine($"{c.Key} : {c.NumberOfModels}"));


// Display a list of makes that have at least two models with >= 400 hp

//cars.Where(car => car.HP >= 400)
//    .GroupBy(car => car.Make)
//    .OrderBy(car => car.Key)
//    .Select(car => new { Make = car.Key, NumberOfModels = car.Count() })
//    .Where(make => make.NumberOfModels >= 2)
//    .ToList()
//    .ForEach(make => Console.WriteLine(make.Make));


// Display there average HP per make

cars.GroupBy(car => car.Make)
    .Select(car => new { Make = car.Key, AverageHP = car.Average(car => car.HP) })
    .ToList()
    .ForEach(car => Console.WriteLine($"{car.Make} {car.AverageHP}"));

    


class CarData
{
    [JsonPropertyName("id")]
    public int ID { get; set; }

    [JsonPropertyName("car_make")]
    public string Make { get; set; }

    [JsonPropertyName("car_models")]
    public string Model { get; set; }

    [JsonPropertyName("car_year")]
    public int Year  { get; set; }

    [JsonPropertyName("number_od_doors")]
    public int NumberOfDoors { get; set; }

    [JsonPropertyName("hp")]
    public int HP { get; set; }
}



