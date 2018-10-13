using System.Collections;

namespace ObjectLiteralToQueryString
{
	public static class HashtableExtensions
    {
		public static bool IsEmpty(this Hashtable hashtable)
		{
			return hashtable.Count == 0;
		}

		public static bool IsNull(this Hashtable hashtable)
        {
            return hashtable is null;
        }
    }
}
