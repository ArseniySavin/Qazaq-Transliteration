//------------------------------------------------------------------------------
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateQazaq
{
    internal static class AbcNet
    {
        private readonly static Dictionary<string, string> abcNet = new Dictionary<string, string>();
        private readonly static Dictionary<string, string> abcNetKZ = new Dictionary<string, string>();

        public static Dictionary<string, string> GetDictionary()
        {

            abcNet.Add("Ч", "Ch");
            abcNet.Add("ч", "ch");
            abcNet.Add("Ш", "Sh");
            abcNet.Add("ш", "sh");
            abcNet.Add("Щ", "Shh");
            abcNet.Add("щ", "shh");
            abcNet.Add("Ё", "Yo");
            abcNet.Add("ё", "yo");
            abcNet.Add("Э", "Eh");
            abcNet.Add("э", "eh");
            abcNet.Add("Ю", "Yu");
            abcNet.Add("ю", "yu");
            abcNet.Add("Я", "Ya");
            abcNet.Add("я", "ya");
            abcNet.Add("Й", "IY");
            abcNet.Add("й", "iy");

            abcNet.Add("Ә", "A'");
            abcNet.Add("ә", "a'");
            abcNet.Add("А", "A");
            abcNet.Add("а", "a");
            abcNet.Add("Б", "B");
            abcNet.Add("б", "b");
            abcNet.Add("В", "V");
            abcNet.Add("в", "v");
            abcNet.Add("Ғ", "Gh");
            abcNet.Add("ғ", "gh");
            abcNet.Add("Г", "G");
            abcNet.Add("г", "g");
            abcNet.Add("Д", "D");
            abcNet.Add("д", "d");
            abcNet.Add("Е", "E");
            abcNet.Add("е", "e");

            abcNet.Add("Ж", "J");
            abcNet.Add("ж", "j");
            abcNet.Add("З", "Z");
            abcNet.Add("з", "z");
            abcNet.Add("И", "I");
            abcNet.Add("и", "i");
            abcNet.Add("К", "K");
            abcNet.Add("к", "k");
            abcNet.Add("Л", "L");
            abcNet.Add("л", "l");
            abcNet.Add("М", "M");
            abcNet.Add("м", "m");
            abcNet.Add("Н", "N");
            abcNet.Add("н", "n");
            abcNet.Add("О", "O");
            abcNet.Add("о", "o");
            abcNet.Add("П", "P");
            abcNet.Add("п", "p");
            abcNet.Add("Р", "R");
            abcNet.Add("р", "r");
            abcNet.Add("С", "S");
            abcNet.Add("с", "s");
            abcNet.Add("Т", "T");
            abcNet.Add("т", "t");
            abcNet.Add("Ұ", "U'");
            abcNet.Add("ұ", "u'");
            abcNet.Add("У", "U");
            abcNet.Add("у", "u");
            abcNet.Add("Ф", "F");
            abcNet.Add("ф", "f");
            abcNet.Add("Х", "H");
            abcNet.Add("х", "h");
            abcNet.Add("Ц", "C");
            abcNet.Add("ц", "c");
            abcNet.Add("Ы", "Y");
            abcNet.Add("ы", "y");
            abcNet.Add("Ъ", "''");
            abcNet.Add("ъ", "''");
            abcNet.Add("Ү", "Y'");
            abcNet.Add("ү", "y'");

            abcNet.Add("Ь", "'");
            abcNet.Add("ь", "'");

            abcNet.Add("Қ", "Q");
            abcNet.Add("қ", "q");
            abcNet.Add("Ң", "Ng");
            abcNet.Add("ң", "ng");
            abcNet.Add("Ө", "O'");
            abcNet.Add("ө", "o'");

            abcNet.Add("Һ", "H'");
            abcNet.Add("һ", "h'");
            abcNet.Add("І", "I");
            abcNet.Add("і", "i");

            return abcNet;
        }

        public static Dictionary<string, string> AbcNetOnlyQazaq() {
            abcNetKZ.Add("Ә", "A'");
            abcNetKZ.Add("ә", "a'");
            abcNetKZ.Add("Ғ", "Gh");
            abcNetKZ.Add("ғ", "gh");
            abcNetKZ.Add("Қ", "Q");
            abcNetKZ.Add("қ", "q");
            abcNetKZ.Add("Ң", "Ng");
            abcNetKZ.Add("ң", "ng");
            abcNetKZ.Add("Ө", "O'");
            abcNetKZ.Add("ө", "o'");
            abcNetKZ.Add("Ұ", "U'");
            abcNetKZ.Add("ұ", "u'");
            abcNetKZ.Add("Ү", "Y'");
            abcNetKZ.Add("ү", "y'");
            abcNetKZ.Add("Һ", "H'");
            abcNetKZ.Add("һ", "h'");
            abcNetKZ.Add("І", "I");
            abcNetKZ.Add("і", "i");

            return abcNetKZ;
        }
    }
}
