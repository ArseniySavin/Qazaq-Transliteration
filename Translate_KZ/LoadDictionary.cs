using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyJson;

namespace Translate_KZ
{
    internal class LoadDictionary
    {
        internal static List<DictionaryModel> GetDictionary(string pathForDict)
        {
            List<string> stringsJson = ReadDictFile(pathForDict);

            return ParseDict(stringsJson);
        }

        private static List<string> ReadDictFile(string pathForDict)
        {
            List<string> stringsJson = new List<string>();
            try
            {
                if (string.IsNullOrEmpty(pathForDict))
                    throw new ArgumentNullException("pathForDict", "Path for dictionary null or empty!");

                if (string.IsNullOrWhiteSpace(pathForDict))
                    throw new ArgumentNullException("pathForDict", "Path for dictionary null or white space!");

                var filesCollection = Directory.GetFiles(pathForDict, "*.json");

                foreach (var item in filesCollection)
                {
                    stringsJson.Add(File.ReadAllText(item));
                }

            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }

            return stringsJson;
        }

        private static List<DictionaryModel> ParseDict(List<string> stringsJson)
        {
            List<DictionaryModel> dictList = new List<DictionaryModel>();

            try
            {
                foreach (var item in stringsJson)
                {
                    DictionaryModel dictModel = item.FromJson<DictionaryModel>();

                    if (dictModel.dict_type == "dict")
                    {
                        if (string.IsNullOrEmpty(dictModel.name))
                            throw new ArgumentNullException("name", "Parametr can not null or empty");

                        if (Object.ReferenceEquals(dictModel.dict, null))
                            throw new ArgumentNullException("dict", "Parametr can not null");

                        dictList.Add(dictModel);
                    }
                }

                return dictList;
            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
