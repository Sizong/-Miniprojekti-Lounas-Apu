using Lounari.Models;


RavintolatContext db = new RavintolatContext();

Console.Write("Give me a username: ");

string user = Console.ReadLine();

Asiaka uusi = new Asiaka()
{
    Nimi = user
};
db.Add(uusi);
db.SaveChanges();

Console.WriteLine("Haluatko luoda uuden ravintolan vai antaa arvion ravintolasta?");
string arviosy�m��n = Console.ReadLine();
if (arviosy�m��n == "arvostelu")
{
    Console.WriteLine("arvostelee");

}
else if (arviosy�m��n == "luoda")
{
    Console.WriteLine("Anna uuden ravintolan nimi");
    string ravintola = Console.ReadLine();
    Console.WriteLine("osoite");
    string osoite = Console.ReadLine();
    Console.WriteLine("kotisivu");
    string kotisivu = Console.ReadLine();
    Console.WriteLine("puhelinnumero");
    string puh = Console.ReadLine();
    Console.WriteLine("s�hk�posti");
    string sposti = Console.ReadLine();
    Console.WriteLine("hinta");
    decimal hinta = Convert.ToDecimal(Console.ReadLine());

    Ravintola uusi1 = new Ravintola()
    {
        Nimi = ravintola,
        Osoite = osoite,
        Kotisivu = kotisivu,
        Puhelinnumero = puh,
        S�hk�posti = sposti,
        Hinta = hinta
    };
    db.Add(uusi1);
    db.SaveChanges();
}