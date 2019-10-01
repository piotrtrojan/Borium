using System.Collections.Generic;

namespace Borium.DomainModel.Entities
{
    public class Epoch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public ICollection<Work> Works { get; set; }
        
    }
}
