public class Catalog
{
    // 1. Закрываем список от внешнего мира
    private List<SpaceObject> _objects = new List<SpaceObject>();

    public string Name { get; private set; }

    // 2. Вычисляемое свойство
    public int ObjectCount
    {
        get { return _objects.Count; }
    }

    public Catalog(string name)
    {
        Name = name;
    }

    // 3. Добавление с проверкой на дубликат
    public bool AddObject(SpaceObject obj)
    {
        // Ищем объект с таким же именем. Если нашли — отказ.
        if (FindObjectByName(obj.Name) != null)
        {
            return false;
        }

        _objects.Add(obj);
        return true;
    }

    // 4. Поиск с игнорированием регистра и пробелов
    public SpaceObject? FindObjectByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return null;
        }

        string searchName = name.Trim();

        foreach (SpaceObject obj in _objects)
        {
            if (string.Equals(obj.Name, searchName, StringComparison.OrdinalIgnoreCase))
            {
                return obj;
            }
        }

        return null; // Не нашли — возвращаем null
    }

    // 5. Удаление
    public bool RemoveObject(string name)
    {
        SpaceObject? obj = FindObjectByName(name);
        if (obj == null)
        {
            return false; // Нечего удалять
        }
        return _objects.Remove(obj);
    }

    // 6. Выдача защитной копии списка
    public List<SpaceObject> GetObjects()
    {
        List<SpaceObject> result = new List<SpaceObject>();
        foreach (SpaceObject obj in _objects)
        {
            result.Add(obj);
        }
        return result;
    }

    // 7. Самостоятельный метод-запрос (сколько объектов дальше 1 млн св. лет)
    public int CountFartherThan(double distance)
    {
        int count = 0;
        foreach (SpaceObject obj in _objects)
        {
            if (obj.DistanceLightYears > distance)
            {
                count += 1;
            }
        }
        return count;
    }
}