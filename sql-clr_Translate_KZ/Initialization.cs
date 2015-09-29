//------------------------------------------------------------------------------
// <copyright file="Initialization.cs" company="-">
// Dictionary have pair key for translate to Qazaq
// Warning: you must save this file using UTF-8. Because you can get false transliteration.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace TranslateQazaq
{

    /// <summary>
    /// QazaqAqparat - ; 
    /// GostB - ; 
    /// AbcNet - ; 
    /// Common - ; 
    /// CyrillicQazaq - this dictionary used for bank;
    /// </summary>
    public enum TransliteType
    {
        QazaqAqparat      = 1,
        GostB             = 2,
        AbcNet            = 3,
        Common            = 4,
        CyrillicQazaq = 6 
    }

    /// <summary>
    /// Type for direction translate
    /// </summary>
    public enum DirectionType
    {
        OnKaz   = 1,
        OutKaz  = 2
    }

    public static class InitializationDictionary
    {
        public static void Dispose() 
        {
            GC.Collect();
        }

        private readonly static Dictionary<string, string> _QazaqAqparat  = new Dictionary<string, string>();
        private readonly static Dictionary<string, string> _gostB         = new Dictionary<string, string>();
        private readonly static Dictionary<string, string> _abcNet        = new Dictionary<string, string>();
        private readonly static Dictionary<string, string> _common        = new Dictionary<string, string>();
        private readonly static Dictionary<string, string> _cirillicQazaq = new Dictionary<string, string>();

        /// <summary>
        /// 
        /// </summary>
        public static string ConvertTo(string text, TransliteType type, DirectionType direct) 
        {
            string output = text;

            Dictionary<string, string> tdictF = SetDictionary(type);

            foreach (KeyValuePair<string, string> key in tdictF)
            {
                if(direct == DirectionType.OnKaz)
                {
                    output = output.Replace(key.Key, key.Value);
                }
                else if(direct == DirectionType.OutKaz)
                {
                    output = output.Replace(key.Value, key.Key);
                }
            }

            Dispose();

            return output;
        }

        private static Dictionary<string, string> SetDictionary(TransliteType type) 
        {
            Dictionary<string, string> tdict = null;

            switch(type){
                case TransliteType.QazaqAqparat: 
                    tdict = _QazaqAqparat; break;
                case TransliteType.GostB: 
                    tdict = _gostB; break;
                case TransliteType.AbcNet: 
                    tdict = _abcNet; break;
                case TransliteType.Common:
                    tdict = _common; break;
                case TransliteType.CyrillicQazaq:
                    tdict = _cirillicQazaq; break;
            }

            return tdict;
        }

        static InitializationDictionary() 
        {
                _QazaqAqparat   = QazaqAqparat.GetDictionary();
                _gostB        = GostB.GetDictionary();
                _abcNet       = AbcNet.GetDictionary();
                _common       = Common.GetDictionary();
                _cirillicQazaq       = QazaqCyrillic.GetDictionary();
        }
    }
}