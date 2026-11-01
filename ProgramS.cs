SpaceObject Earth = new SpaceObject("Земля", "Планета", "Галактика Млечный путь, Солнечная система, третья планета от Солнца", 0, "5,972 × 10²¹ тонн", "Каменистая планета, на которой мы живём");

SpaceObject Sgr = new SpaceObject("Sgr A*", "Сверхмассивная чёрная дыра", "Центр галактики Млечный путь", 27000, "4,297 ± 0,042 миллиона масс Солнца", "Стрелец A* представляет собой высокоплотный объект — сверхмассивную чёрную дыру, окружённую горячим газовым облаком. Сама чёрная дыра не излучает свет, но материя, падающая на неё, образует аккреционный диск, который и испускает излучение в радио-, инфракрасном, рентгеновском и других диапазонах");

SpaceObject PSR = new SpaceObject("PSR J1748-2446ad", "Пульсар", "Пульсар принадлежит шаровому скоплению Terzan 5 в созвездии Стрельца", 18000, "Две солнечных массы", "PSR J1748−2446ad — радиопульсар с частотой вращения 716 Гц, соответствует периоду 0,00139595482(6) секунды. Это второй по скорости вращения среди известных пульсаров. Текущий рекордсмен — XTE J1739−285 (1122 оборота в секунду), но он не подтверждён, PSR J0952-0607 делает 707 оборотов в секунду. Пульсар был открыт Дж. Хесселсом из университета МакГилла с помощью радиотелескопа Грин-Бэнк");

SpaceObject TC = new SpaceObject("3C 273", "Квазар", "Расположен в созвездии Девы", 2440000000, "886 ± 187 миллионов масс Солнца", " Квазар в созвездии Дева. Считается первым астрономическим объектом, идентифицированным в качестве квазара. Интенсивно исследуется на протяжении многих лет, начиная с открытия квазаров в 1963 году. Самый яркий (mv ~ 13) квазар на звёздном небе Земли, и один из самых близких (z ~ 0,16). Принадлежит к подклассу квазаров, называемых блазарами. В 1995 году с помощью телескопа «Хаббл» были получены оптические изображения одного из джетов 3C 273. Линейная протяжённость джета составляет ~200 тыс. св. лет (~62 кпк), а видимый размер — 23''. Изображения позволили различить сложную структуру джета, состоящую из нескольких ярких узлов, разделённых областями слабой эмиссии.");

Console.WriteLine($"{Earth.Name}, {Sgr.Name} до приближения: {Earth.Light}, {Sgr.Light}");
Earth.Zoom(0);
Sgr.Zoom(10000);
Console.WriteLine($"После приближения: {Earth.Light}, {Sgr.Light}");

Console.WriteLine();

Earth.Zoom(-10);
Console.WriteLine($"{Earth.Name} После неверного приближения: {Earth.Light}");
Sgr.Zoom(30000);
Console.WriteLine($"{Sgr.Name} После большего приближения: {Sgr.Light}");

Console.WriteLine();

TC.NalInfo("[Данные удалены]");
Console.WriteLine($"Объект {TC.Name} попал под дело секретной организации: {TC.Info}");

Console.WriteLine();

Console.WriteLine(">>> Объект №1 <<<");
Console.WriteLine($"Название: {Earth.Name}");
Console.WriteLine($"Тип: {Earth.Type}");
Console.WriteLine($"Расположение: {Earth.Location}");
Console.WriteLine($"Расстояние (в световых годах): {Earth.Light}");
Console.WriteLine($"Масса: {Earth.Mass}");
Console.WriteLine($"Информация: {Earth.Info}");
bool EUnik = Earth.Unik();
if (EUnik)
{
    Console.WriteLine("Объект уникален *****");
} else
{
    Console.WriteLine("Объект не уникален *");
}

Console.WriteLine();

Console.WriteLine(">>> Объект №2 <<<");
Console.WriteLine($"Название: {Sgr.Name}");
Console.WriteLine($"Тип: {Sgr.Type}");
Console.WriteLine($"Расположение: {Sgr.Location}");
Console.WriteLine($"Расстояние (в световых годах): {Sgr.Light}");
Console.WriteLine($"Масса: {Sgr.Mass}");
Console.WriteLine($"Информация: {Sgr.Info}");

Console.WriteLine();

Console.WriteLine(">>> Объект №3 <<<");
Console.WriteLine($"Название: {PSR.Name}");
Console.WriteLine($"Тип: {PSR.Type}");
Console.WriteLine($"Расположение: {PSR.Location}");
Console.WriteLine($"Расстояние (в световых годах): {PSR.Light}");
Console.WriteLine($"Масса: {PSR.Mass}");
Console.WriteLine($"Информация: {PSR.Info}");
bool PSRUnik = PSR.Unik();
if (PSRUnik)
{
    Console.WriteLine("Объект уникален *****");
} else
{
    Console.WriteLine("Объект не уникален *");
}

Console.WriteLine();

Console.WriteLine(">>> Объект №4 <<<");
Console.WriteLine($"Название: {TC.Name}");
Console.WriteLine($"Тип: {TC.Type}");
Console.WriteLine($"Расположение: {TC.Location}");
Console.WriteLine($"Расстояние (в световых годах): {TC.Light}");
Console.WriteLine($"Масса: {TC.Mass}");
Console.WriteLine($"Информация: {TC.Info}");