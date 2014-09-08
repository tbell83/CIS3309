using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace bell_programming_midterm
{
    class cipher
    {
        private ArrayList array = new ArrayList();

        public cipher() { }

        public string decrypt(string toDecrypt, int shift) {
            char[] chars = toDecrypt.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = Convert.ToChar(Convert.ToInt16(chars[i]) + shift);
            }

            return String.Join("",chars);
        }

        public string encrypt(string toEncrypt, int shift)
        {
            char[] chars = toEncrypt.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = Convert.ToChar(Convert.ToInt16(chars[i]) - shift);
            }

            return String.Join("", chars);
        }
    }
}