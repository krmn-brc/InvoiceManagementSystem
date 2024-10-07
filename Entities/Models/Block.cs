

using Entities.Models.Common;

namespace Entities.Models
{
    public class Block:BaseEntity
    {
        public int Id { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfHousesOnTheFloors { get; set; }
        public string BlockName { get; set; }


        public ICollection<House> Houses { get; set; }
    }
}