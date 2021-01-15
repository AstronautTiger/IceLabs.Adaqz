using IceLabs.Adaqz.Interfaces;

namespace IceLabs.Adaqz.Models
{
    public class Home : IIdentifiable, INameable
    {
        public long Id { get; set; }
        public string Name { get; set; }        
    }
}
