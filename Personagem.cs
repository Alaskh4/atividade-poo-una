public class Personagem
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }

    public Personagem(string nome, int vida, int ataque)
    {
        Nome = nome;
        Vida = vida;
        Ataque = ataque;
    }

    public void Atacar()
    {
        Console.WriteLine(Nome + " atacou causando " + Ataque + " de dano.");
    }
}
