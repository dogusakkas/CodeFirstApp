using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Helper
{
    public static class HelperMethod
    {
        public static string KarekterDuzelt(string metin)
        {
            metin = metin.ToLower();
            return metin.Replace("İ", "I").
                        Replace("ı", "i").
                        Replace("Ğ", "G").
                        Replace("ğ", "g").
                        Replace("Ö", "O").
                        Replace("ö", "o").
                        Replace("Ü", "U").
                        Replace("ü", "u").
                        Replace("Ş", "S").
                        Replace("ş", "s").
                        Replace("Ç", "C").
                        Replace("ç", "c").
                        Replace(" ", "-").
                        Replace("#", "").
                        Replace("*", "").
                        Replace("'", "").
                        Replace("/", "").
                        Replace("\"", "").
                        Replace("$", "").
                        Replace("|", "").
                        Replace("[", "").
                        Replace("]", "").
                        Replace("^", "").
                        Replace("@", "").
                        Replace("~", "").
                        Replace("(", "").
                        Replace(")", "").
                        Replace("%", "").
                        Replace(".", "").
                        Replace("&", "").
                        Replace(",", "");
        }
    }
}