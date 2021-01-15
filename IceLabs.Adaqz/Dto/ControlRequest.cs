using IceLabs.Adaqz.Models;
using System.Collections.Generic;

namespace IceLabs.Adaqz.Dto
{
    public class ControlRequest
    {
        public List<ControlRequestRoom> Rooms { get; set; }
    }
}
