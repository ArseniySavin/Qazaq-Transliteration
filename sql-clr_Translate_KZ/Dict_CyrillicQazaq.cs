//------------------------------------------------------------------------------
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateQazaq
{
    internal static class CyrillicQazaq
    {
        private readonly static Dictionary<string, string> _CirQaz1251 = new Dictionary<string, string>();

        public static Dictionary<string, string> GetDictionary()
        {

            _CirQaz1251.Add("Ә", "Ј"); //Ј
            _CirQaz1251.Add("ә", "ј");

            _CirQaz1251.Add("І", "І"); //І
            _CirQaz1251.Add("і", "і");

            _CirQaz1251.Add("Ң", "Ѕ"); //Ѕ
            _CirQaz1251.Add("ң", "ѕ");

            _CirQaz1251.Add("Ғ", "Є"); //Є
            _CirQaz1251.Add("ғ", "є");

            _CirQaz1251.Add("Ү", "Ї"); //Ї
            _CirQaz1251.Add("ү", "ї");

            _CirQaz1251.Add("Ұ", "Ў"); //Ў
            _CirQaz1251.Add("ұ", "ў");

            _CirQaz1251.Add("Қ", "Ќ"); //Ќ
            _CirQaz1251.Add("қ", "ќ");

            _CirQaz1251.Add("Ө", "Ґ"); //Ґ
            _CirQaz1251.Add("ө", "ґ");

            _CirQaz1251.Add("Һ", "Ћ"); //Ћ
            _CirQaz1251.Add("һ", "ћ");

            return _CirQaz1251;
        }
    }
}
