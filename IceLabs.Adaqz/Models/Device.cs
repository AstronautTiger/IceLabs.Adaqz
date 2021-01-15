using IceLabs.Adaqz.Interfaces;

namespace IceLabs.Adaqz.Models
{
    public class Device : IIdentifiable, INameable
    {
        public long Id { get; set; }
        public long HomeId { get; set; }
        public long RoomId { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; } = DeviceType.Heater;
    }
}
