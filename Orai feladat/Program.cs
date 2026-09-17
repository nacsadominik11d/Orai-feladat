string Utasnev = "Márton Károly";
int Tavolsag = 14;
bool Ejszaka = true;
int Alapdíj = 1100;
int kmDíj = 440;
double EjszakaSzorzo = 1.2;
// 3.feladat
double alapertek = Alapdíj + (Tavolsag * kmDíj);
double osszesen = alapertek;
if (Ejszaka)
{
    osszesen = osszesen * EjszakaSzorzo;
}
Console.WriteLine("------------------------------------------");
Console.WriteLine($"Utas neve: {Utasnev}");
Console.WriteLine($"Megtett Távolság: {Tavolsag} km");
Console.WriteLine($"Alapérték: {alapertek} Ft");
Console.WriteLine($"Éjszaka összeg: {osszesen} Ft");
if (Ejszaka) Console.WriteLine($"Státusz : 20% éjszakai pótlék felszámolva.");
else Console.WriteLine($"Státusz : Normál Díj Felszámolva.");
Console.WriteLine("------------------------------------------");

