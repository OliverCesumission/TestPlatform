using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlatform.Core.Abstractions
{
    public class GuidGenerator
    {
        public GuidGenerator()
        {

        }

        public Guid NewCombGuid()
        {
            byte[] guidArray = Guid.NewGuid().ToByteArray();
            DateTime baseDate = new DateTime(1980, 1, 1);
            DateTime now = DateTime.Now;

            //Get the days and milleseconds since 1900/01/01
            TimeSpan days = new TimeSpan(now.Ticks - baseDate.Ticks);
            TimeSpan msecs = now.TimeOfDay;

            //Convert to byte arrays
            byte[] daysArray = BitConverter.GetBytes((int)days.TotalDays);
            byte[] msecsArray = BitConverter.GetBytes((long)msecs.TotalMilliseconds);

            //Reverse byte arrays for SQL Server Compatibility
            Array.Reverse(daysArray);
            Array.Reverse(msecsArray);

            //Copy into GUID (overwrite the last 6bytes)
            Array.Copy(daysArray, daysArray.Length - 2, guidArray, guidArray.Length - 6, 2);
            Array.Copy(msecsArray, msecsArray.Length - 2, guidArray, guidArray.Length - 4, 4);
            return new Guid(guidArray);
        }
    }
}
