namespace Borium.DomainModel.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public Work Work { get; set; }
        public int WorkId { get; set; }
        public bool IsScan { get; set; }
        public string FileName { get; set; }
    }
}
