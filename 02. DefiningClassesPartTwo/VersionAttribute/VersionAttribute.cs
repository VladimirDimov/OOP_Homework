
namespace VersionAttribute
{
    using System;
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
       AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]

    public class VersionAttribute : Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; set; }
        public int Minor { get; set; }
        public string Version
        {
            get
            {
                return string.Format("{0}.{1}", this.Major, this.Minor);
            }
            private set { ;}
        }
    }
}
