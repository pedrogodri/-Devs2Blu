namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models
{
    public class Pokemons
    {
        public int count { get; set; }
        public String next { get; set; }
        public String previous { get; set; }
        public List<ResultsPokemons> results { get; set; }
    }

    public class ResultsPokemons
    {
        public String name { get; set; }
        public String url { get; set; }
    }
}
