namespace Collections
{
    public class Garage
    {
        List<Car> _carList;
        string _name;

        public Garage(string name)
        {
            _carList = new List<Car>();
            _name = name;
        }
        public void CreateCar(int id, string brand, string color)
        {
            _carList.Add(new Car { Id = id, Brand = brand, Color = color});
        }
        public string GetCarById(int id)
        {
            if (_carList.Count > 0 && _carList.Exists(x => x.Id == id))
            {
                Car? foundCar = _carList.Find(x => x.Id == id);
                return $"Id: {foundCar.Id}\nBrand: {foundCar.Brand}\nColor: {foundCar.Color}";
            }
            return "No car found";
        }
        public string GetAllCar()
        {
            string cars = "";
            if (_carList.Count > 0)
            {
                foreach (Car item in _carList)
                    cars += $"Id: {item.Id}\nBrand: {item.Brand}\nColor: {item.Color}\n\n";
                return cars;         
            }
            return "No cars in list";
        }
        public void RemoveCarById(int id)
        {
            if (_carList.Count > 0 && _carList.Exists(x => x.Id == id))
            {
                Car? foundCar = _carList.Find(x => x.Id == id);
                _carList.Remove(foundCar);
            }
        }
    }
}
