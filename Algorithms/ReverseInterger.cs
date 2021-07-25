namespace Algorithms
{
    public class ReverseInterger
    {
        public int Reverse(int x)
        {
            var s = x.ToString();
            var isNegative = false;
            if (s.Length > 0 && s[0] == '-')
            {
                isNegative = true;
            }
            var cString = isNegative ? s.Substring(1, s.Length - 1).ToCharArray() : s.Substring(0, s.Length).ToCharArray();
            for (int i = 0; i < cString.Length / 2; i++)
            {
                var temp = cString[i];
                cString[i] = cString[cString.Length - 1 - i];
                cString[cString.Length - 1 - i] = temp;

            }
            try
            {
                x = int.Parse(cString);
                if (isNegative)
                {
                    x = x * -1;
                }
            }
            catch
            {
                x = 0;
            }
            return x;
        }
    }
}