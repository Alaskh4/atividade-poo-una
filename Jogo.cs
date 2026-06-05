public class Jogo
{
    public void Iniciar()
    {
        Personagem jogador = new Personagem("Herói", 100, 20);
        Inimigo inimigo = new Inimigo("Goblin", 50);
        Item pocao = new Item("Poção de Vida");

        jogador.Atacar();
        inimigo.ReceberDano(jogador.Ataque);
        pocao.Usar();
    }
}
