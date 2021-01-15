using IceLabs.Adaqz.Common;

namespace IceLabs.Adaqz.Models
{
    public sealed class ControlStatus : StringEnum<ControlStatus>
    {
        internal const string OkValue = "OK";
        internal const string NoAccessValue = "NoAccess";
        internal const string InvalidParamsValue = "InvalidParams";
        internal const string InternalErrorValue = "InternalError";

        private ControlStatus(string value) : base(value)
        {
        }

        public static bool operator ==(ControlStatus lhs, ControlStatus rhs)
        {
            return ReferenceEquals(lhs, null) ? ReferenceEquals(rhs, null) : lhs.Equals(rhs);
        }

        public static bool operator !=(ControlStatus lhs, ControlStatus rhs)
        {
            return !(lhs == rhs);
        }
      
        public static implicit operator string(ControlStatus status)
        {
            return status.Value;
        }

        public static readonly ControlStatus Ok = new ControlStatus(OkValue);
        public static readonly ControlStatus NoAccess = new ControlStatus(NoAccessValue);
        public static readonly ControlStatus InvalidParams = new ControlStatus(InvalidParamsValue);
        public static readonly ControlStatus InternalError = new ControlStatus(InternalErrorValue);
    }
}
