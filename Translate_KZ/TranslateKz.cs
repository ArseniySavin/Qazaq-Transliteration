using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate_KZ
{
    public enum DirectionType
    {
        OnKaz,
        OutKaz
    };

    public class TranslateKz
    {
        List<DictionaryModel> _dict;
        string _dictName = string.Empty;

        public TranslateKz(string pathForDict, string dictName)
        {
            try
            {
                _dictName = dictName;
                _dict = LoadDictionary.GetDictionary(pathForDict);

                if (_dict.Count == 0)
                    throw new MemberAccessException($"Not exist dictionary files in {pathForDict}");
            }
            catch (MemberAccessException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string SetDictionary
        {
            set
            {
                _dictName = value;
            }
        }

        public string ConvertTo(string translateString, DirectionType direction)
        {
            string _translateString = translateString;

            try
            {

                if (!_dict.Exists(m => m.name == _dictName))
                    throw new KeyNotFoundException($"Dicrtionary {_dictName} not fount in collection");

                Dictionary<string, string> dict = _dict.FirstOrDefault(m => m.name == _dictName + "1").dict;

                foreach (KeyValuePair<string, string> key in dict)
                {
                    if (direction == DirectionType.OnKaz)
                    {
                        _translateString = _translateString.Replace(key.Key, key.Value);
                    }
                    else if (direction == DirectionType.OutKaz)
                    {
                        _translateString = _translateString.Replace(key.Value, key.Key);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return _translateString;
        }
    }
}
