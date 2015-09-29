//------------------------------------------------------------------------------
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateQazaq
{
    internal static class QazaqCyrillic
    {
        private readonly static Dictionary<string, string> _QazCir1251 = new Dictionary<string, string>();

        public static Dictionary<string, string> GetDictionary()
        {

            _QazCir1251.Add("Ә", "Ј"); //Ј
            _QazCir1251.Add("ә", "ј");

            _QazCir1251.Add("І", "І"); //І
            _QazCir1251.Add("і", "і");

            _QazCir1251.Add("Ң", "Ѕ"); //Ѕ
            _QazCir1251.Add("ң", "ѕ");

            _QazCir1251.Add("Ғ", "Є"); //Є
            _QazCir1251.Add("ғ", "є");

            _QazCir1251.Add("Ү", "Ї"); //Ї
            _QazCir1251.Add("ү", "ї");

            _QazCir1251.Add("Ұ", "Ў"); //Ў
            _QazCir1251.Add("ұ", "ў");

            _QazCir1251.Add("Қ", "Ќ"); //Ќ
            _QazCir1251.Add("қ", "ќ");

            _QazCir1251.Add("Ө", "Ґ"); //Ґ
            _QazCir1251.Add("ө", "ґ");

            _QazCir1251.Add("Һ", "Ћ"); //Ћ
            _QazCir1251.Add("һ", "ћ");

            return _QazCir1251;
        }
    }
}
