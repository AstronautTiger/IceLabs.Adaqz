using IceLabs.Adaqz.Models;
using System.Collections.Generic;

namespace IceLabs.Adaqz.Dto
{
    public class ContentResponse
    {
        public List<Home> Homes { get; set; } = new List<Home>();
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<Device> Devices { get; set; } = new List<Device>();
    }
}
