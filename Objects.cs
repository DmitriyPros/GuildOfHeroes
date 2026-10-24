using System.Text.Json.Serialization;

public class SpaceObject
{
    public string Name;
    public string Type;
    public string Location;
    public double Light;
    public string Mass;
    public string Info;

    public SpaceObject(string name, string type, string loc, double light, string m, string i)
    {
        Name = name;
        Location = loc;
        Type = type;
        Light = light;
        Mass = m;
        Info = i;
    }
}