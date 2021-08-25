using System;
namespace SpinningDiscs
{
    public class IOpticalDisk
    {
        public interface IOpticalDisc
        {
            void SpinDisc();
            void StoreData();
            void WriteData();
            void ReadData();
        }
    }
}
