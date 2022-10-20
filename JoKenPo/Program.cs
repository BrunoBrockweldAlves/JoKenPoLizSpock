using System;
using System.Linq;

namespace JoKenPo
{
    internal class Program
    {
        //Implementar sistema de console para jogo.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Jogador
    {
        public string Name { get; set; }
        public FiguraJogada FiguraJogada { get; set; }

        public bool DefinirResultado(FiguraJogada figuraAdversario)
        {
            if (this.FiguraJogada.GanhaDe.Contains((int)figuraAdversario.TipoFigura))
            {
                return true;
            }
            //Implementar outras lógicas de resultado
            return false;
        }
    }

    public enum TipoFigura
    {
        Pedra = 1,
        Papel = 2,
        Tesoura = 3,
        Pocky = 4,
        Grilo = 5
    }

    public abstract class FiguraJogada
    {
        public TipoFigura TipoFigura {get;set;}
        public int[] GanhaDe { get; set; }
        public int[] PerdeDe {get;set;}
        public int[] EmpataDe {get;set;}

        public FiguraJogada()
        {
        }
    }

    /// <summary>
    /// Uma classe para cada figura.
    /// Implementar outras classes.
    /// </summary>
    public class Pedra : FiguraJogada
    {
        public Pedra()
        {
            TipoFigura = TipoFigura.Pedra;
            GanhaDe = new int[] { 
                (int)TipoFigura.Tesoura,
                (int)TipoFigura.Grilo};
        }
    }

    public class Jogo
    {
        public string DefinirGanhador(Jogador jogador1, Jogador jogador2)
        {
            return $"Jogador {(jogador1.DefinirResultado(jogador2.FiguraJogada) ? jogador1.Name : jogador2.Name) } ganhou, parabéns!";
        }
    }
}