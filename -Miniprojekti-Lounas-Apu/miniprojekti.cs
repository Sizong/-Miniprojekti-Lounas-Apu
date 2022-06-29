


RavintolatContext db = new RavintolatContext();
List<Ravintola> result = db.Ravintolas.ToList();
Console.Write("Give me a username: ");

string user = Console.ReadLine();

Asiaka uusi = new Asiaka()
{
    Nimi = user
};
db.Add(uusi);
db.SaveChanges();

Console.WriteLine("Haluatko luoda uuden ravintolan, arvostella ravintolan vai mennä vaa syömään johonkin ravintolaan?");
Console.WriteLine("Anna vastauksesi arvostelu, luoda tai syödä");
string arviosyömään = Console.ReadLine();

if (arviosyömään == "syödä")
{

    foreach (Ravintola ravintola in result)
    {
        Console.WriteLine(ravintola.Nimi);
    }
    Console.WriteLine();
}


if (arviosyömään == "arvostelu")
{
    Console.WriteLine("arvostelee");

}
if (arviosyömään == "luoda")
{
    Console.WriteLine("Anna uuden ravintolan nimi");
    string ravintola = Console.ReadLine();
    Console.WriteLine("osoite");
    string osoite = Console.ReadLine();
    Console.WriteLine("kotisivu");
    string kotisivu = Console.ReadLine();
    Console.WriteLine("puhelinnumero");
    string puh = Console.ReadLine();
    Console.WriteLine("sähköposti");
    string sposti = Console.ReadLine();
    Console.WriteLine("hinta");
    decimal hinta = Convert.ToDecimal(Console.ReadLine());

    Ravintola uusi1 = new Ravintola()
    {
        Nimi = ravintola,
        Osoite = osoite,
        Kotisivu = kotisivu,
        Puhelinnumero = puh,
        Sähköposti = sposti,
        Hinta = hinta
    };
    db.Add(uusi1);
    db.SaveChanges();
}
