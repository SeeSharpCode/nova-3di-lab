namespace Nova3diLab.Utility
{
    public static class StringExtensions
    {
        public static byte[] ToByteArray(this string value, int length)
        {
            byte[] bytes = new byte[length];

            char[] chars = value.ToCharArray(); 

            for (int i = 0; i < (chars.Length > length ? length : chars.Length); i++)
                bytes[i] = (byte)chars[i];
                
            return bytes;
        }
    }
}
