namespace Strategy.Models
{
    public class PeopleResult
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public People[] Results { get; set; }
    }
}
