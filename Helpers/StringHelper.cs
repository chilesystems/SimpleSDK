namespace SimpleSDK.Helpers
{
    public static class StringHelper
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            // if (value.Length > maxLength)
            //     Console.WriteLine(String.Format("Truncate performed: {0} to {1}", value, value.Substring(0, maxLength)));
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
