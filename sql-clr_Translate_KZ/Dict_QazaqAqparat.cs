//------------------------------------------------------------------------------
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateQazaq
{
    internal static class QazaqAqparat
    {
        private readonly static Dictionary<string, string> Qazaqparat = new Dictionary<string, string>();

        public static Dictionary<string, string> GetDictionary()
        {

            Qazaqparat.Add("Ә", "Ä");
            Qazaqparat.Add("ә", "ä");
            Qazaqparat.Add("Ғ", "Ğ");
            Qazaqparat.Add("ғ", "ğ");
            Qazaqparat.Add("Қ", "Q");
            Qazaqparat.Add("қ", "q");
            Qazaqparat.Add("Ң", "Ñ");
            Qazaqparat.Add("ң", "ñ");
            Qazaqparat.Add("Ө", "Ö");
            Qazaqparat.Add("ө", "ö");
            Qazaqparat.Add("Ұ", "U");
            Qazaqparat.Add("ұ", "u");
            Qazaqparat.Add("Ү", "Ü");
            Qazaqparat.Add("ү", "ü");
            Qazaqparat.Add("Һ", "H");
            Qazaqparat.Add("һ", "h");
            Qazaqparat.Add("І", "I");
            Qazaqparat.Add("і", "i");

            Qazaqparat.Add("Ё", "Yo");
            Qazaqparat.Add("ё", "yo");
            Qazaqparat.Add("И", "Ï");
            Qazaqparat.Add("и", "ï");
            Qazaqparat.Add("Ч", "Ç");
            Qazaqparat.Add("ч", "ç");
            Qazaqparat.Add("Ш", "Ş");
            Qazaqparat.Add("ш", "ş");
            Qazaqparat.Add("Щ", "Şş");
            Qazaqparat.Add("щ", "şş");
            Qazaqparat.Add("Ю", "Yu");
            Qazaqparat.Add("ю", "yu");
            Qazaqparat.Add("Я", "Ya");
            Qazaqparat.Add("я", "ya");

            Qazaqparat.Add("А", "A");
            Qazaqparat.Add("а", "a");
            Qazaqparat.Add("Б", "B");
            Qazaqparat.Add("б", "b");
            Qazaqparat.Add("В", "V");
            Qazaqparat.Add("в", "v");
            Qazaqparat.Add("Г", "G");
            Qazaqparat.Add("г", "g");
            Qazaqparat.Add("Д", "D");
            Qazaqparat.Add("д", "d");
            Qazaqparat.Add("Е", "E");
            Qazaqparat.Add("е", "e");

            Qazaqparat.Add("Ж", "J");
            Qazaqparat.Add("ж", "j");
            Qazaqparat.Add("З", "Z");
            Qazaqparat.Add("з", "z");

            Qazaqparat.Add("Й", "Y");
            Qazaqparat.Add("й", "y");
            Qazaqparat.Add("К", "K");
            Qazaqparat.Add("к", "k");
            Qazaqparat.Add("Л", "L");
            Qazaqparat.Add("л", "l");
            Qazaqparat.Add("М", "M");
            Qazaqparat.Add("м", "m");
            Qazaqparat.Add("Н", "N");
            Qazaqparat.Add("н", "n");
            Qazaqparat.Add("О", "O");
            Qazaqparat.Add("о", "o");
            Qazaqparat.Add("П", "P");
            Qazaqparat.Add("п", "p");
            Qazaqparat.Add("Р", "R");
            Qazaqparat.Add("р", "r");
            Qazaqparat.Add("С", "S");
            Qazaqparat.Add("с", "s");
            Qazaqparat.Add("Т", "T");
            Qazaqparat.Add("т", "t");
            Qazaqparat.Add("У", "W");
            Qazaqparat.Add("у", "w");
            Qazaqparat.Add("Ф", "F");
            Qazaqparat.Add("ф", "f");
            Qazaqparat.Add("Х", "H");
            Qazaqparat.Add("х", "h");
            Qazaqparat.Add("Ц", "C");
            Qazaqparat.Add("ц", "c");

            Qazaqparat.Add("Ъ", "''");
            Qazaqparat.Add("ъ", "''");
            Qazaqparat.Add("Ы", "İ");
            Qazaqparat.Add("ы", "i");
            Qazaqparat.Add("Ь", "'");
            Qazaqparat.Add("ь", "'");
            Qazaqparat.Add("Э", "E");
            Qazaqparat.Add("э", "e");

            return Qazaqparat;
        }
    }
}
