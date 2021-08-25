using System;
namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string Contents { get; set; }
        public string DiscType { get; set; }

        public BaseDisc()
        {
        }
    }
}
