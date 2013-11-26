// 現在のユーザーが管理者か調べる: .NET Tips: C#, VB.NET
// http://dobon.net/vb/dotnet/system/isadmin.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TimeShift
{
    class TokenType
    {
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool GetTokenInformation(IntPtr TokenHandle,
            TOKEN_INFORMATION_CLASS TokenInformationClass,
            IntPtr TokenInformation,
            uint TokenInformationLength,
            out uint ReturnLength);

        public enum TOKEN_INFORMATION_CLASS
        {
            TokenUser = 1,
            TokenGroups,
            TokenPrivileges,
            TokenOwner,
            TokenPrimaryGroup,
            TokenDefaultDacl,
            TokenSource,
            TokenType,
            TokenImpersonationLevel,
            TokenStatistics,
            TokenRestrictedSids,
            TokenSessionId,
            TokenGroupsAndPrivileges,
            TokenSessionReference,
            TokenSandBoxInert,
            TokenAuditPolicy,
            TokenOrigin,
            TokenElevationType,
            TokenLinkedToken,
            TokenElevation,
            TokenHasRestrictions,
            TokenAccessInformation,
            TokenVirtualizationAllowed,
            TokenVirtualizationEnabled,
            TokenIntegrityLevel,
            TokenUIAccess,
            TokenMandatoryPolicy,
            TokenLogonSid,
            MaxTokenInfoClass
        }

        public enum TOKEN_ELEVATION_TYPE
        {
            TokenElevationTypeDefault = 1,
            TokenElevationTypeFull,
            TokenElevationTypeLimited
        }

        /// <summary>
        /// 昇格トークンの種類を取得する
        /// </summary>
        /// <returns>昇格トークンの種類を示すTOKEN_ELEVATION_TYPE。
        /// 取得に失敗した時でもTokenElevationTypeDefaultを返す。</returns>
        public static TOKEN_ELEVATION_TYPE GetTokenElevationType()
        {
            TOKEN_ELEVATION_TYPE returnValue =
                TOKEN_ELEVATION_TYPE.TokenElevationTypeDefault;

            //Windows Vista以上か確認
            if (Environment.OSVersion.Platform != PlatformID.Win32NT ||
                Environment.OSVersion.Version.Major < 6)
            {
                return returnValue;
            }

            TOKEN_ELEVATION_TYPE tet =
                TOKEN_ELEVATION_TYPE.TokenElevationTypeDefault;
            uint returnLength = 0;
            uint tetSize = (uint)Marshal.SizeOf((int)tet);
            IntPtr tetPtr = Marshal.AllocHGlobal((int)tetSize);
            try
            {
                //アクセストークンに関する情報を取得
                if (GetTokenInformation(
                    System.Security.Principal.WindowsIdentity.GetCurrent().Token,
                    TOKEN_INFORMATION_CLASS.TokenElevationType,
                    tetPtr, tetSize, out returnLength))
                {
                    //結果を取得
                    returnValue = (TOKEN_ELEVATION_TYPE)Marshal.ReadInt32(tetPtr);
                }
            }
            finally
            {
                //解放する
                Marshal.FreeHGlobal(tetPtr);
            }

            return returnValue;
        }
    }
}
