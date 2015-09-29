//------------------------------------------------------------------------------
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateQazaq
{
    internal static class Common
    {
        private readonly static Dictionary<string, string> _CommonKaz = new Dictionary<string, string>();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> GetDictionary()
        {

            _CommonKaz.Add("Ё", "Yo");
            _CommonKaz.Add("ё", "yo");
            _CommonKaz.Add("Ж", "Zh");
            _CommonKaz.Add("ж", "zh");
            _CommonKaz.Add("Х", "Kh");
            _CommonKaz.Add("х", "kh");
            _CommonKaz.Add("Ц", "Tc");
            _CommonKaz.Add("ц", "tc");
            _CommonKaz.Add("Ч", "Ch");
            _CommonKaz.Add("ч", "ch");
            _CommonKaz.Add("Ш", "Sh");
            _CommonKaz.Add("ш", "sh");
            _CommonKaz.Add("Щ", "ShCh");
            _CommonKaz.Add("щ", "shch");
            _CommonKaz.Add("Э", "Eh");
            _CommonKaz.Add("э", "eh");
            _CommonKaz.Add("Ю", "Yu");
            _CommonKaz.Add("ю", "yu");
            _CommonKaz.Add("Я", "Ya");
            _CommonKaz.Add("я", "ya");
            _CommonKaz.Add("Ы", "Y");
            _CommonKaz.Add("ы", "y");

            _CommonKaz.Add("Ң", "Ng");
            _CommonKaz.Add("ң", "ng");
            _CommonKaz.Add("Ғ", "Gh");
            _CommonKaz.Add("ғ", "gh");

            _CommonKaz.Add("є", "eh");
            _CommonKaz.Add("А", "A");
            _CommonKaz.Add("а", "a");
            _CommonKaz.Add("Б", "B");
            _CommonKaz.Add("б", "b");
            _CommonKaz.Add("В", "V");
            _CommonKaz.Add("в", "v");
            _CommonKaz.Add("Г", "G");
            _CommonKaz.Add("г", "g");
            _CommonKaz.Add("Д", "D");
            _CommonKaz.Add("д", "d");
            _CommonKaz.Add("Е", "E");
            _CommonKaz.Add("е", "e");

            _CommonKaz.Add("З", "Z");
            _CommonKaz.Add("з", "z");
            _CommonKaz.Add("И", "I");
            _CommonKaz.Add("и", "i");
            _CommonKaz.Add("Й", "I");
            _CommonKaz.Add("й", "i");
            _CommonKaz.Add("К", "K");
            _CommonKaz.Add("к", "k");
            _CommonKaz.Add("Л", "L");
            _CommonKaz.Add("л", "l");
            _CommonKaz.Add("М", "M");
            _CommonKaz.Add("м", "m");
            _CommonKaz.Add("Н", "N");
            _CommonKaz.Add("н", "n");
            _CommonKaz.Add("О", "O");
            _CommonKaz.Add("о", "o");
            _CommonKaz.Add("П", "P");
            _CommonKaz.Add("п", "p");
            _CommonKaz.Add("Р", "R");
            _CommonKaz.Add("р", "r");
            _CommonKaz.Add("С", "S");
            _CommonKaz.Add("с", "s");
            _CommonKaz.Add("Т", "T");
            _CommonKaz.Add("т", "t");
            _CommonKaz.Add("У", "U");
            _CommonKaz.Add("у", "u");
            _CommonKaz.Add("Ф", "F");
            _CommonKaz.Add("ф", "f");
            _CommonKaz.Add("Ъ", "''");
            _CommonKaz.Add("ъ", "''");

            _CommonKaz.Add("Ь", "'");
            _CommonKaz.Add("ь", "'");

            _CommonKaz.Add("Є", "EH");
            _CommonKaz.Add("№", "#");
            _CommonKaz.Add("«", "");
            _CommonKaz.Add("»", "");
            _CommonKaz.Add("—", "-");

            _CommonKaz.Add("Ә", "A");
            _CommonKaz.Add("ә", "a");
            _CommonKaz.Add("Қ", "Q");
            _CommonKaz.Add("қ", "q");
            _CommonKaz.Add("Ө", "O");
            _CommonKaz.Add("ө", "o");
            _CommonKaz.Add("Ұ", "U");
            _CommonKaz.Add("ұ", "u");
            _CommonKaz.Add("Ү", "U");
            _CommonKaz.Add("ү", "u");
            _CommonKaz.Add("Һ", "H");
            _CommonKaz.Add("һ", "h");
            _CommonKaz.Add("і", "i");
            _CommonKaz.Add("І", "I");


            return _CommonKaz;
        }
    }
}
