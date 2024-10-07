
using Entities.Models.Common;

namespace Entities.Models
{
    public class House:BaseEntity
    {
        public int ApartmentId { get; set; }
        public string TypeInfo { get; set; }
        public int FloorNumber { get; set; }
        public int DoorNumber { get; set; }
        public bool IsOwner { get; set; }
        public bool State { get; set; }
        public int UserId { get; set; }
        public Block Block { get; set; }
    }
}