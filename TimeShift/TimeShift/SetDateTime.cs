// NonSoft - NTPサーバの現在日時をシステム時計に設定するサンプル(C#.NET)
// http://homepage2.nifty.com/nonnon/SoftSample/CS.NET/SampleNtpDateTime.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeShift
{
    class SetDateTime
    {
        // システム時計の日時設定APIの引数
        [System.Runtime.InteropServices.StructLayout(
         System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SystemTime
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMiliseconds;
        }

        // システム時計の日時設定APIの定義
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern bool SetLocalTime(ref SystemTime sysTime);

        public static DateTime setNTP()
        {
            // NTPサーバへの接続用UDP生成
            System.Net.Sockets.UdpClient objSck;
            System.Net.IPEndPoint ipAny =
                new System.Net.IPEndPoint(System.Net.IPAddress.Any, 0);
            objSck = new System.Net.Sockets.UdpClient(ipAny);

            // NTPサーバへのリクエスト送信
            Byte[] sdat = new Byte[48];
            sdat[0] = 0xB;
            
            try
            {
                objSck.Send(sdat, sdat.GetLength(0), "time.windows.com", 123);
            }
            catch (Exception e)
            {
                return DateTime.Now;
                throw;
            }

            // NTPサーバから日時データ受信
            Byte[] rdat = objSck.Receive(ref ipAny);

            // 1900年1月1日からの経過時間(日時分秒)
            long lngAllS; // 1900年1月1日からの経過秒数
            long lngD;    // 日
            long lngH;    // 時
            long lngM;    // 分
            long lngS;    // 秒

            // 1900年1月1日からの経過秒数計算
            lngAllS = (long)(
                      rdat[40] * Math.Pow(2, (8 * 3)) +
                      rdat[41] * Math.Pow(2, (8 * 2)) +
                      rdat[42] * Math.Pow(2, (8 * 1)) +
                      rdat[43]);

            // 1900年1月1日からの経過(日時分秒)計算
            lngD = lngAllS / (24 * 60 * 60); // 日
            lngS = lngAllS % (24 * 60 * 60); // 残りの秒数
            lngH = lngS / (60 * 60);         // 時
            lngS = lngS % (60 * 60);         // 残りの秒数
            lngM = lngS / 60;                // 分
            lngS = lngS % 60;                // 秒

            // 現在の日時(DateTime)計算
            DateTime dtTime = new DateTime(1900, 1, 1);
            dtTime = dtTime.AddDays(lngD);
            dtTime = dtTime.AddHours(lngH);
            dtTime = dtTime.AddMinutes(lngM);
            dtTime = dtTime.AddSeconds(lngS);

            // グリニッジ標準時から日本時間への変更
            dtTime = dtTime.AddHours(9);

            // 現在の日時表示
            System.Diagnostics.Trace.WriteLine(dtTime);

            // システム時計の日時設定
            return dtTime;
        }

        // システム時計の日時設定
        public static void SetSysTime(DateTime dtm)
        {
            SystemTime sTime = new SystemTime();
            sTime.wYear = (ushort)dtm.Year;
            sTime.wMonth = (ushort)dtm.Month;
            sTime.wDay = (ushort)dtm.Day;
            sTime.wHour = (ushort)dtm.Hour;
            sTime.wMinute = (ushort)dtm.Minute;
            sTime.wSecond = (ushort)dtm.Second;
            sTime.wMiliseconds = (ushort)dtm.Millisecond;
            SetLocalTime(ref sTime);
        }

    }

}
