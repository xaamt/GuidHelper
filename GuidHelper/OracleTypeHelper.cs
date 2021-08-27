using System;

namespace GuidHelper
{
    public static class OracleTypeHelper
    {
        public static Guid OracleToDotNet(Guid input) => new Guid(ParseHex(input.ToString("N")));
        
        public static Guid DotNetToOracle(Guid input) => new Guid(BitConverter.ToString(input.ToByteArray()).Replace("-", null));


        public static bool IsOracleGuid(string text) => !text.Contains("-");

        private static byte[] ParseHex(string text)
        {
            var ret = new byte[text.Length / 2];
            for (var i = 0; i < ret.Length; i++)
            {
                ret[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
            }
            return ret;
        }
    }
}
