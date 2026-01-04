using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TTNT_DAL
{
    public class LuuTru
    {
        private string filePath = "dulieu.txt";

        public void LuuKetQua(string ketqua)
        {
            File.AppendAllText(filePath, ketqua + "\n");
        }

        public string[] DocKetQua()
        {
            if (File.Exists(filePath))
                return File.ReadAllLines(filePath);
            else
                return new string[0];
        }
    }
}
