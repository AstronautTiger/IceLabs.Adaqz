using IceLabs.Adaqz.Interfaces;

namespace IceLabs.Adaqz.Models
{
    public class Room : IIdentifiable, INameable
    {
        public long Id { get; set; }
        public long HomeId { get; set; }
        public string Name { get; set; }        
        public bool? HeatingEnabled { get; set; }
        public int? TargetTemperature { get; set; }
        public int? Temperature { get; set; }
    }
}
