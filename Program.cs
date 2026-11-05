Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());



// Начало проверки здоровья
Hero lowProbe = new Hero("Проверка нижней границы", -100);
Hero highProbe = new Hero("Проверка верхней границы", 5000);
Console.WriteLine($"Нижняя граница: {lowProbe.Health}/{lowProbe.MaxHealth}");
Console.WriteLine($"Верхняя граница: {highProbe.Health}/{highProbe.MaxHealth}");
Console.WriteLine($"Александр до действий: {alexander.Health}/{alexander.MaxHealth}");

alexander.TakeDamage(30);
alexander.Heal(10);
Console.WriteLine($"Обычные действия: {alexander.Health}");
alexander.Heal(5000);
Console.WriteLine($"Большое лечение: {alexander.Health}");
alexander.Heal(-20);
Console.WriteLine($"Отказ в лечении: {alexander.Health}");
alexander.TakeDamage(5000);
Console.WriteLine($"Большой урон: {alexander.Health}; жив: {alexander.IsAlive()}");
alexander.Heal(20);
Console.WriteLine($"Восстановление: {alexander.Health}");
Console.WriteLine($"Артём без изменений: {artem.Health}/{artem.MaxHealth}");
// Конец проверки здоровья


Hero spacedProbe = new Hero("   Александр   ", 150);
Hero emptyProbe = new Hero("   ", 100);

Console.WriteLine($"Имя с пробелами: [{spacedProbe.Name}]");
Console.WriteLine($"Пустая запись: [{emptyProbe.Name}]");

