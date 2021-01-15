using IceLabs.Adaqz.Interfaces;

namespace IceLabs.Adaqz.Models
{
    public class ControlRequestRoom : IIdentifiable
    {
        public long Id { get; set; }
        public bool HeatingEnabled { get; set; }
        public int TargetTemperature { get; set; }
    }
}