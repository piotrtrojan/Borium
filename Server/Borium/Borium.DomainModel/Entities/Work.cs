using System.Collections.Generic;

namespace Borium.DomainModel.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Age { get; set; }
        public ICollection<ArtistWork> Artists { get; set; }
        public ICollection<Note> Notes { get; set; }
        public Epoch Epoch { get; set; }
        public int EpochId { get; set; }
    }
}
