using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using _1ste_semester_prøve_eksamen;

List<Album> album = new List<Album>() {
new Album("15525-2512.235.23", "Batman", 1965, "Hergé", 500, 20),
new Album("225-346235.234", "Joker", 2012, "Karl", 21,300),
new Album("215-6565.2352", "Superman", 1978, "John", 5000,400)};

static void FindAlbum(int år,string tegner, List<Album> album)
{
    int found = 0;
    foreach (Album a in album)
    {
        if (a.Tegner == tegner && a.UdgivelsesDato < år)
        {
            Console.WriteLine($"ISBN: {a.Isbn}");
            Console.WriteLine($"Title: {a.Titel}");
            Console.WriteLine($"Year of Release: {a.UdgivelsesDato}");
            Console.WriteLine($"Artist: {a.Tegner}");
            Console.WriteLine($"Price: {a.Pris}");
            found++;
        }
    };
    if(found==0)
        Console.WriteLine("***Ikke fundet***");
}

FindAlbum(1990, "Hergé", album);
//output:
//ISBN: 15525 - 2512.235.23
//Title: Batman
//Year of Release: 1965
//Artist: Hergé
//Price: 20
FindAlbum(1990, "Paul", album);
//output:
//***Ikke fundet***

static int FindTotal(List<Album> album)
{
    int total = 0;
    foreach(Album a in album)
    {
        total += a.Pris; 
    }
    return total;
}

Console.WriteLine(FindTotal(album));
//output:
//720

