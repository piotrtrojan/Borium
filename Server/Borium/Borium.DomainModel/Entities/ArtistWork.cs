using System;
using System.Collections.Generic;
using System.Text;

namespace Borium.DomainModel.Entities
{
    public class ArtistWork
    {
        public int Id { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public Work Work { get; set; }
        public int WorkId { get; set; }
    }
}
