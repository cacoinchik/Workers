namespace Workers.Models
{
    public class Children
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public byte Age { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
