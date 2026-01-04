using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNT_BUS
{
    public class VHUATHUAT
    {
        // Ví dụ: tính tổng các số lẻ trong chuỗi
        public int ThucHien(string input)
        {
            var numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(x => int.Parse(x)).ToArray();

            int sum = 0;
            foreach (var num in numbers)
                if (num % 2 != 0)
                    sum += num;

            return sum;
        }
    }
}
