using System.Text.RegularExpressions;

namespace KonturMap.Server.DAL
{
    public class PhoneConverter
    {
		private static Regex digitsOnly = new Regex(@"[^\d]", RegexOptions.Compiled);

		public static long Convert(string phone)
		{
			return long.Parse(digitsOnly.Replace(phone, ""));
		}
    }
}
