using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string zoro = "";
            for (int i = 0; i < original.Length; i++)
            {
                zoro = zoro + original[i] + original[i];
            }
            return zoro;
        }
    }
}
