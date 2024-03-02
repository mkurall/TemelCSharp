namespace SiniflarVeListeler
{    
    public class City
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public City(int code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
