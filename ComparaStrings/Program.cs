string string1, string2;

string LerString()
{
    Console.WriteLine("Digite um texto: ");
    return Console.ReadLine();
}

void ComparaTextos(string root, string root2)
{
    bool result = root.Equals(root2);
    string aux;
    if (result)
    {
        aux = "iguais";
    }
    else 
    {
        aux = "diferentes";
    }
    Console.WriteLine($"Os textos <{root}> e <{root2}> são {aux}");
}

string1 = LerString();
string2 = LerString();

ComparaTextos(string1, string2);