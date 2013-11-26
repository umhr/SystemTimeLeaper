// C#でUnixエポックタイムを取得する． - Paradigm Shift Design
// http://ishitoya.hatenablog.com/entry/20080321/1206081336


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeShift
{
    class UnixEpochTime
    {
        public const long EPOCH = 621355968000000000;
        public static long now()
        {
            return (DateTime.Now.ToUniversalTime().Ticks - EPOCH) / 10000;
        }
        public static long toUnixEpochTime(long time)
        {
            return (time - EPOCH) / 10000;
        }
    }
}
