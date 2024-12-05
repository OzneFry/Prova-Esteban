string tipo1 = Console.ReadLine().ToLower();
string tipo2 = Console.ReadLine().ToLower();
string tipo3 = Console.ReadLine().ToLower();

string animal = "";
if (tipo1 == "vertebrado")
{
    if (tipo2 == "ave")
    {
        animal = (tipo3 == "carnivoro") ? "AGUIA" : "POMBA";
    }
    else if (tipo1 == "invertebrado")
    {
        if (tipo2 == "inseto")
        {
            animal = (tipo3 == "hematofago") ? "PULGA" : "LAGARTA";
        }
        else if (tipo2 == "anelideo")
        {
            animal = (tipo3 == "hematofago") ? "SANGUESSUGA" : "MINHOCA";
        }
    }
}
Console.WriteLine(animal);