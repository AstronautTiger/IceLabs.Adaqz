using IceLabs.Adaqz.Interfaces;

namespace IceLabs.Adaqz.Models
{
    public class ControlResponseRoom : IIdentifiable
    {
        public long Id { get; set; }
        public ControlStatus Status { get; set; }
    }
}
