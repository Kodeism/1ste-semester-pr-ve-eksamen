using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using _1ste_semester_prøve_eksamen;

//opgave: 3.2.3 
List<Album> album = new List<Album>() {
new Album("15525-2512.235.23", "Batman", 1965, "Hergé", 500, 20),
new Album("225-346235.234", "Joker", 2012, "Karl", 21,300),
new Album("215-6565.2352", "Superman", 1978, "John", 5000,400)};




//opgave 3.2.4
static void FindAlbum(int år,string tegner, List<Album> album)
{
    int found = 0; //antal af tegneserier vi har fundet i vores album som passer det givet år og tegner
    foreach (Album a in album)
    {
        if (a.Tegner == tegner && a.UdgivelsesDato < år)
        {
            Console.WriteLine($"ISBN: {a.Isbn}");
            Console.WriteLine($"Title: {a.Titel}");
            Console.WriteLine($"Year of Release: {a.UdgivelsesDato}");
            Console.WriteLine($"Artist: {a.Tegner}");
            Console.WriteLine($"Price: {a.Pris}");
            found++; //hvis tegneserien er lavt af den regtige tegner og er udgivet det regtige år så udskriver vi dens info og øger antallet af fundet serier med 1.
        }
    }
    if (found == 0)//hvis antalet af fundet serier i vores album er 0 så udskriver vi 'ikke fundet'
    {
        Console.WriteLine("***Ikke fundet***");
    }
}



//Dette kan også skrives som:
static void FindAlbum2(int år, string tegner, List<Album> album)
{
    int found = 0;//antal af tegneserier vi har fundet i vores album som passer det givet år og tegner
    foreach (Album a in album)
    {
        if (a.Tegner == tegner)
        {
            if (a.UdgivelsesDato < år)
            {
                Console.WriteLine($"ISBN: {a.Isbn}");
                Console.WriteLine($"Title: {a.Titel}");
                Console.WriteLine($"Year of Release: {a.UdgivelsesDato}");
                Console.WriteLine($"Artist: {a.Tegner}");
                Console.WriteLine($"Price: {a.Pris}");
                found++;//hvis tegneserien er lavt af den regtige tegner og er udgivet det regtige år så udskriver vi dens info og øger antallet af fundet serier med 1.
            }
        }
    }
    if (found == 0)//hvis antalet af fundet serier i vores album er 0 så udskriver vi 'ikke fundet'
    {
        Console.WriteLine("***Ikke fundet***");
    }
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


//opgave 3.2.5 
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

//opgave 3.3.1 
static void doubble(int tal, int doubbles)    
{
    Console.WriteLine(tal);
    for (int i = 0; i < doubbles; i++)
    {
        Console.WriteLine(tal*=2);
    }
}

doubble(2,5);
//output
//2
//4
//8
//16
//32
//64

//opgave 3.3.2 

int count = -20;
while(count<-10)
{
    if(count%2!=0)
        Console.WriteLine(count);
    count++;
}
//output:
//-19
//- 17
//- 15
//- 13
//- 11