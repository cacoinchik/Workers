namespace Workers.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public byte Age { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string FamilyStatus { get; set; }
        public string Post { get; set; }
        public string Degree { get; set; }

        public List<Children> Childrens { get; set; }
    }
}
