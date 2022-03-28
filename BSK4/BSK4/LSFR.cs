using System;
using System.Collections.Generic;

namespace BSK4
{
    public static class LSFR
    {
        public static void Init(string data)
        {
            _Bits = new List<int>();
            _Polynomial = new List<int>();

            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] == '1') {
                    _Polynomial.Add(i);
                }
            }

            var x = Convert.ToString(DateTime.Now.ToBinary(), 2);
            x = x.Substring(x.Length - data.Length);

            for(int i = 0; i < x.Length; i++)
            {
                _Bits.Add(int.Parse(x[i].ToString()));
            }

            Console.WriteLine("Wartosc poczatkowa: {0}", x);
        }

        public static int GenerateBit()
        {
            var result = _Bits[_Bits.Count - 1];
            var last_bit = _Bits[_Polynomial[_Polynomial.Count - 1]];

            for(int i = _Polynomial.Count - 1; i > 0; i--)
            {
                int bit1 = _Polynomial[i - 1];

                if(_Bits[bit1] == last_bit)
                {
                    last_bit = 0;
                }
                else
                {
                    last_bit = 1;
                }
            }

            for(int i = _Bits.Count - 1; i > 0; i--)
            {
                _Bits[i] = _Bits[i - 1];
            }

            _Bits[0] = last_bit;
            return result;
        }

        private static List<int> _Bits;
        private static List<int> _Polynomial;
    }
}