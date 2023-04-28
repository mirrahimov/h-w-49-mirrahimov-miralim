using System.Numerics;

namespace home_work_49.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
