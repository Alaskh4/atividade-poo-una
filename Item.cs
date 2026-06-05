using System;

public class Item
{
    public string Nome { get; set; }

    public Item(string nome)
    {
        Nome = nome;
    }

    public void Usar()
    {
        Console.WriteLine("Você utilizou o item " + Nome + ".");
    }
}
