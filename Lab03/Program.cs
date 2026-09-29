/*
 * Student ID : 1690705270
 * Name       : Punyapat Bouruang
 * Section    : 129B
 * No.        : 39
 * Course     : GI113 Computer Programming (GI)
 */
const int Maxlevel = 10;

var bossName = "Kirin";
var rank = 5;
int level = 7;
int maxHp = 240;
int currentHp = 115;
float attackPower = 42.5f;
double critMultiplier = 1.75;
bool isBoss = true;

Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
Console.WriteLine($"Boss Name: {bossName}");
Console.WriteLine($"Rank: {rank}");
Console.WriteLine($"Level: {level} / {Maxlevel}");
Console.WriteLine($"HP: {currentHp} / {maxHp}");
Console.WriteLine($"Attack Power: {attackPower}");
Console.WriteLine($"Critical Multiplier: {critMultiplier}");
Console.WriteLine($"Is Boss: {isBoss}");
Console.WriteLine();

Console.WriteLine("----- Implicit Conversion: HP as double -----");
double currentHpDouble = currentHp;
Console.WriteLine($"HP (Double): {currentHpDouble}");
Console.WriteLine();

Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
double hpPercentExact = currentHpDouble * 100 / maxHp;
Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");
Console.WriteLine();

Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
int attackDisplay = (int)attackPower;
Console.WriteLine($"Attack Power (int cast): {attackDisplay}");
Console.WriteLine();

Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
int critCast = (int)critMultiplier;
int critConvert = Convert.ToInt32(critMultiplier);
Console.WriteLine($"Crit Multiplier (int cast): {critCast})");
Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");