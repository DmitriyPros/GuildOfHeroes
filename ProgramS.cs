// Расстояния — от Земли, в световых годах.
// Earth = 0: наблюдаем «сами с себя».
using System.Data.Common;
using System.Security.Cryptography;

SpaceObject Earth = new SpaceObject(
    "Земля", "Планета",
    "Галактика Млечный путь, Солнечная система, третья планета от Солнца",
    0,
    "5,972 × 10²¹ тонн",
    "Каменистая планета, на которой мы живём");

SpaceObject Sgr = new SpaceObject(
    "Sgr A*", "Сверхмассивная чёрная дыра",
    "Центр галактики Млечный путь",
    27000,
    "4,297 ± 0,042 миллиона масс Солнца",
    "Стрелец A* — сверхмассивная чёрная дыра в центре Млечного Пути, окружённая горячим газовым облаком");

SpaceObject PSR = new SpaceObject(
    "PSR J1748-2446ad", "Пульсар",
    "Шаровое скопление Terzan 5 в созвездии Стрельца",
    18000,
    "Две солнечных массы",
    "Радиопульсар с частотой вращения 716 Гц. Второй по скорости вращения среди известных пульсаров");

SpaceObject TC = new SpaceObject(
    "3C 273", "Квазар",
    "Созвездие Девы",
    2_440_000_000,
    "886 ± 187 миллионов масс Солнца",
    "Первый астрономический объект, идентифицированный как квазар. Самый яркий квазар на небе Земли");

// Начальное состояние 
Console.WriteLine(">>> Начальное состояние <<<");
Console.WriteLine($"Earth={Earth.DistanceLightYears}, Sgr={Sgr.DistanceLightYears}, " +
                  $"PSR={PSR.DistanceLightYears}, TC={TC.DistanceLightYears}");
Console.WriteLine();

// --- Допустимое действие + независимость объектов ---
Console.WriteLine("--- Sgr.Approach(10000) ---");
Sgr.Approach(10000);
Console.WriteLine($"Earth={Earth.DistanceLightYears}, Sgr={Sgr.DistanceLightYears}, " +
                  $"PSR={PSR.DistanceLightYears}, TC={TC.DistanceLightYears}");
Console.WriteLine("(изменилось только Sgr: 27000 → 17000)");
Console.WriteLine();

// --- Недопустимое действие ---
Console.WriteLine("--- Sgr.Approach(-500) ---");
Sgr.Approach(-500);
Console.WriteLine($"Sgr={Sgr.DistanceLightYears} (не изменилось — guard сработал)");
Console.WriteLine();

// --- Верхняя граница: большое приближение ---
Console.WriteLine("--- PSR.Approach(1_000_000) ---");
PSR.Approach(1_000_000);
Console.WriteLine($"PSR={PSR.DistanceLightYears} (ограничено нулём, не ушло в минус)");
Console.WriteLine();

// --- UpdateInfo с «до/после» ---
Console.WriteLine("--- TC.UpdateInfo ---");
Console.WriteLine($"До: {TC.Info}");
TC.UpdateInfo("[Данные удалены]");
Console.WriteLine($"После: {TC.Info}");
Console.WriteLine();

// --- Демонстрация работы свойства DistanceLightYears ---
SpaceObject Sirius = new SpaceObject(
    "Sirius А", "Звезда", "α Большого Пса", -100.5, "2,063 ± 0,023 массы Солнца", "Главная и самая яркая компонента двойной звёздной системы Сириуса, которую мы видим на ночном небе невооружённым глазом"
);
Console.WriteLine("--- Демонстрация свойства DistanceLightYears ---");
Console.WriteLine(Sirius.GetInfo());
Console.WriteLine($"Создание с -100 → {Sirius.DistanceLightYears}");
Console.WriteLine();

// --- 1 Демонстрация работы полного свойства Name ---
SpaceObject Cygnus1 = new SpaceObject(
    "Cygnus A     ", "Радиогалактика", "Созвездие Лебедя", 760_000_000, "Около 1 триллиона масс Солнца", "Мощная радиогалактика. Является одним из самых ярких внегалактических источников радиоизлучения в наблюдаемой Вселенной. В центре Cygnus A находится сверхмассивная чёрная дыра с массой примерно (2,5 ± 0,7) × 10⁹ масс Солнца. Вокруг неё вращается аккреционный диск из газа и пыли. Часть материи, падающей на чёрную дыру, ускоряется и выбрасывается в виде узких струй (джетов) со скоростью, близкой к скорости света."
);
Console.WriteLine("--- Демонстрация полного свойства Name ---");
Console.WriteLine(Cygnus1.GetInfo());
Console.WriteLine();

// --- 2 Демонстрация работы полного свойства Name ---
SpaceObject Cygnus2 = new SpaceObject(
    " ", "Радиогалактика", "Созвездие Лебедя", 760_000_000, "Около 1 триллиона масс Солнца", "Мощная радиогалактика. Является одним из самых ярких внегалактических источников радиоизлучения в наблюдаемой Вселенной. В центре Cygnus A находится сверхмассивная чёрная дыра с массой примерно (2,5 ± 0,7) × 10⁹ масс Солнца. Вокруг неё вращается аккреционный диск из газа и пыли. Часть материи, падающей на чёрную дыру, ускоряется и выбрасывается в виде узких струй (джетов) со скоростью, близкой к скорости света."
);
Console.WriteLine("--- Демонстрация полного свойства Name ---");
Console.WriteLine(Cygnus2.GetInfo());
Console.WriteLine();

// --- Карточки объектов через GetInfo() ---
Console.WriteLine(">>> Объект №1 <<<");
Console.WriteLine(Earth.GetInfo());
if (Earth.IsPulsar())
{
    Console.WriteLine("Уникален: да *****");
}
else
{
    Console.WriteLine("Уникален: нет *");
}
Console.WriteLine();

Console.WriteLine(">>> Объект №2 <<<");
Console.WriteLine(Sgr.GetInfo());
if (Sgr.IsPulsar())
{
    Console.WriteLine("Уникален: да *****");
}
else
{
    Console.WriteLine("Уникален: нет *");
}
Console.WriteLine();

Console.WriteLine(">>> Объект №3 <<<");
Console.WriteLine(PSR.GetInfo());
if (PSR.IsPulsar())
{
    Console.WriteLine("Уникален: да *****");
}
else
{
    Console.WriteLine("Уникален: нет *");
}
Console.WriteLine();

Console.WriteLine(">>> Объект №4 <<<");
Console.WriteLine(TC.GetInfo());
if (TC.IsPulsar())
{
    Console.WriteLine("Уникален: да *****");
}
else
{
    Console.WriteLine("Уникален: нет *");
}
Console.WriteLine();

// Работа с защищённым каталогом
Console.WriteLine(">>> Каталог объектов <<<");

Catalog catalog = new Catalog("Каталог объектов");

// Демонстрация успешного добавления
catalog.AddObject(Earth);
catalog.AddObject(Sgr);
catalog.AddObject(PSR);
catalog.AddObject(TC);
catalog.AddObject(Sirius);
catalog.AddObject(Cygnus1);

Console.WriteLine($"Успешно добавлено объектов: {catalog.ObjectCount}");

// Демонстрация отказа (дубликат)
bool isDuplicateAdded = catalog.AddObject(Earth);
Console.WriteLine($"Попытка добавить Землю второй раз: {isDuplicateAdded}"); // False

// Поиск (существующий и несуществующий)
SpaceObject? foundObj = catalog.FindObjectByName("   sgr a*   "); // С пробелами и маленькими буквами
if (foundObj != null)
{
    Console.WriteLine($"Найден по запросу «   sgr a*   »: {foundObj.Name}");
}
else
{
    Console.WriteLine("Объект не найден.");
}

SpaceObject? notFoundObj = catalog.FindObjectByName("Марс");
if (notFoundObj == null)
{
    Console.WriteLine("Объект 'Марс' не найден в каталоге.");
}

// Удаление
Console.WriteLine($"Удаление Марса: {catalog.RemoveObject("Марс")}"); // False, его нет
Console.WriteLine($"Удаление Земли: {catalog.RemoveObject("Земля")}"); // True
Console.WriteLine($"Объектов после удаления: {catalog.ObjectCount}");

// Выдача защитной копии списка
List<SpaceObject> copyList = catalog.GetObjects();
copyList.Clear(); // Очищаем копию
Console.WriteLine($"В копии осталось: {copyList.Count}");
Console.WriteLine($"В каталоге по-прежнему: {catalog.ObjectCount}"); // Каталог защищен

// Метод-запрос
int farObjects = catalog.CountFartherThan(1_000_000_000);
Console.WriteLine($"Объектов дальше 1 млрд св. лет: {farObjects}");

Console.WriteLine();
