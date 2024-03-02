using SiniflarVeListeler;

List<City> cityList = new List<City>();

cityList.Add(new City(35, "İzmir"));
cityList.Add(new City(34, "İstanbul"));

foreach (City city in cityList)
{
    Console.WriteLine(city.Code + " - " + city.Name);
}

cityList.RemoveAt(1);

Console.WriteLine("Yeni Liste");
foreach (City city in cityList)
{
    Console.WriteLine(city.Code + " - " + city.Name);
}