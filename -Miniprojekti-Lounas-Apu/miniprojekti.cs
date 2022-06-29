


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

Console.WriteLine("Haluatko luoda uuden ravintolan, arvostella ravintolan vai menn� vaa sy�m��n johonkin ravintolaan?");
Console.WriteLine("Anna vastauksesi arvostelu, luoda tai sy�d�");
string arviosy�m��n = Console.ReadLine();

if (arviosy�m��n == "sy�d�")
{

    foreach (Ravintola ravintola in result)
    {
        Console.WriteLine(ravintola.Nimi);
    }
    Console.WriteLine();
}


if (arviosy�m��n == "arvostelu")
{
    Console.WriteLine("arvostelee");

}
if (arviosy�m��n == "luoda")
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
