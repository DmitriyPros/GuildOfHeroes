using System.Collections.Generic;

public class Catalog
{
    public string Name { get; private set; }
    public List<SpaceObject> Objects { get; private set; } = new List<SpaceObject>();

    public Catalog(string name)
    {
        Name = name;
    }
}