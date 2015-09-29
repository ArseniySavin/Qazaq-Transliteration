//------------------------------------------------------------------------------
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateQazaq
{
    internal static class GostB
    {
        private readonly static Dictionary<string, string> gostB = new Dictionary<string, string>();

        public static Dictionary<string, string> GetDictionary()
        {

            gostB.Add("Ё", "Yo");
            gostB.Add("ё", "yo");
            gostB.Add("Ж", "Zh");
            gostB.Add("ж", "zh");
            gostB.Add("Ц", "Cz");
            gostB.Add("ц", "cz");
            gostB.Add("Ч", "Ch");
            gostB.Add("ч", "ch");
            gostB.Add("Ш", "Sh");
            gostB.Add("ш", "sh");
            gostB.Add("Щ", "Shh");
            gostB.Add("щ", "shh");
            gostB.Add("Ю", "Yu");
            gostB.Add("ю", "yu");
            gostB.Add("Я", "Ya");
            gostB.Add("я", "ya");
            gostB.Add("Ң", "Nh");
            gostB.Add("ң", "nh");
            gostB.Add("Ғ", "Gh");
            gostB.Add("ғ", "gh");

            gostB.Add("Ө", "O'");
            gostB.Add("ө", "o'");
            gostB.Add("Ұ", "U");
            gostB.Add("ұ", "u");
            gostB.Add("Ү", "U'");
            gostB.Add("ү", "u'");
            gostB.Add("Һ", "H'");
            gostB.Add("һ", "h'");


            gostB.Add("Ә", "A'");
            gostB.Add("ә", "a'");
            gostB.Add("А", "A");
            gostB.Add("а", "a");

            gostB.Add("Б", "B");
            gostB.Add("б", "b");
            gostB.Add("В", "V");
            gostB.Add("в", "v");
            gostB.Add("Г", "G");
            gostB.Add("г", "g");
            gostB.Add("Д", "D");
            gostB.Add("д", "d");
            gostB.Add("Е", "E");
            gostB.Add("е", "e");

            gostB.Add("З", "Z");
            gostB.Add("з", "z");
            gostB.Add("И", "I'");
            gostB.Add("и", "i'");
            gostB.Add("І", "I");
            gostB.Add("і", "i");
            gostB.Add("Й", "J");
            gostB.Add("й", "j");
            gostB.Add("К", "K");
            gostB.Add("к", "k");
            gostB.Add("Қ", "Q");
            gostB.Add("қ", "q");
            gostB.Add("Л", "L");
            gostB.Add("л", "l");
            gostB.Add("М", "M");
            gostB.Add("м", "m");
            gostB.Add("Н", "N");
            gostB.Add("н", "n");
            gostB.Add("О", "O");
            gostB.Add("о", "o");
            gostB.Add("П", "P");
            gostB.Add("п", "p");
            gostB.Add("Р", "R");
            gostB.Add("р", "r");
            gostB.Add("С", "S");
            gostB.Add("с", "s");
            gostB.Add("Т", "T");
            gostB.Add("т", "t");
            gostB.Add("У", "W");
            gostB.Add("у", "w");
            gostB.Add("Ф", "F");
            gostB.Add("ф", "f");
            gostB.Add("Х", "H'");
            gostB.Add("х", "h'");

            gostB.Add("Ъ", "''");
            gostB.Add("ъ", "''");
            gostB.Add("Ы", "Y");
            gostB.Add("ы", "y");
            gostB.Add("Ь", "'");
            gostB.Add("ь", "'");
            gostB.Add("Э", "E'");
            gostB.Add("э", "e'");

            return gostB;
        }
    }
}
