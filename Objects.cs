public class SpaceObject
{
    private string _name = "Безымянный объект";

    public string Name
    {
        get
        {
            return _name;
        }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _name = "Безымянный объект";
                return;
            }

            _name = value.Trim();
        }
    }
    public string Type;
    public string Location;
    public double DistanceLightYears { get; private set; }
    public string Mass;
    public string Info;

    public SpaceObject(string name, string type, string location,
                       double distanceLightYears, string mass, string info)
    {
        Name = name;
        Type = type;
        Location = location;
        Info = info;
        Mass = mass;

        DistanceLightYears = distanceLightYears;
        if (DistanceLightYears < 0)
        {
            DistanceLightYears = 0;
        }
    }
        
    public void Approach(double lightYears)
    {
        if (lightYears <= 0)
        {
            return;
        }

        DistanceLightYears -= lightYears;

        if (DistanceLightYears < 0)
        {
            DistanceLightYears = 0;
        }
    }

    public void UpdateInfo(string info)
    {
        Info = info;
    }

    public bool IsPulsar()
    {
        return Type.ToLower() == "пульсар";
    }

    public string GetInfo()
    {
        return $">>> {Name} <<<\n" +
               $"Тип: {Type}\n" +
               $"Расположение: {Location}\n" +
               $"Расстояние: {DistanceLightYears} св. лет\n" +
               $"Масса: {Mass}\n" +
               $"Информация: {Info}";
    }
}