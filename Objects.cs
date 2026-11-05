public class SpaceObject
{
    public string Name;
    public string Type;
    public string Location;
    public double DistanceLightYears;
    public string Mass;
    public string Info;

    public SpaceObject(string name, string type, string location,
                       double distanceLightYears, string mass, string info)
    {
        Name = name;
        Type = type;
        Location = location;
        DistanceLightYears = distanceLightYears;
        Mass = mass;
        Info = info;
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