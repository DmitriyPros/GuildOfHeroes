// Расстояния — от Земли, в световых годах.
// Earth = 0: наблюдаем «сами с себя».
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
if (TC.IsPulsar()) {
    Console.WriteLine("Уникален: да *****");
} else {
    Console.WriteLine("Уникален: нет *");
}
