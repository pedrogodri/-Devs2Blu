namespace Devs2Blu.ProjetosAula.APIChuckNorrisMVC.Models
{
    public class ChuckNorris
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<ResultsChuck> result { get; set; }
    }

    public class ResultsChuck
    {
        public string value { get; set; }
        public string img { get; set; }
        public string url { get; set; }
    }
}
