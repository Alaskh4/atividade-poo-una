using System;

public class Jogo
{
    public void Iniciar()
    {
        Personagem jogador = new Personagem("Heroi", 100, 20);
        Inimigo inimigo = new Inimigo("Goblin", 50);
        Item pocao = new Item("Pocao de Vida");

        jogador.Atacar();
        inimigo.ReceberDano(jogador.Ataque);
        pocao.Usar();
    }
}
