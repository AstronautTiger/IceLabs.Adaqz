using IceLabs.Adaqz.Common;


namespace IceLabs.Adaqz.Models
{
    public class DeviceType : StringEnum<DeviceType>
    {
        internal const string HeaterValue = "Heater";

        private DeviceType(string value) : base(value)
        {

        }

        public static bool operator ==(DeviceType lhs, DeviceType rhs)
        {
            return ReferenceEquals(lhs, null) ? ReferenceEquals(rhs, null) : lhs.Equals(rhs);
        }

        public static bool operator !=(DeviceType lhs, DeviceType rhs)
        {
            return !(lhs == rhs);
        }

        public static implicit operator string(DeviceType deviceType)
        {
            return deviceType.Value;
        }

        public static readonly DeviceType Heater = new DeviceType(HeaterValue);

    }
}
