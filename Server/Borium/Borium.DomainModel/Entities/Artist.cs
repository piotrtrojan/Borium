using System.Collections.Generic;

namespace Borium.DomainModel.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public ICollection<ArtistWork> Works { get; set; }


    }
}
