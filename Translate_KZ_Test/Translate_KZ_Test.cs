using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translate_KZ;

namespace Translate_KZ_Test
{
    [TestClass]
    public class Translate_KZ_Test
    {
        string parhForDict = @"C:\Projects\GitHubRepos\Qazaq-Transliteration\Dictionary"; // \Dictionary

        [TestMethod]
        public void GetDictionary_CyrillicQazaq_OnKaz()
        {
            var test = new TranslateKz(parhForDict, "CyrillicQazaq");

            var res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);

            Assert.AreEqual(res, "НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ");
        }

        [TestMethod]
        public void GetDictionary_QazaqAqparat_OnKaz()
        {
            var test = new TranslateKz(parhForDict, "QazaqAqparat");

            var res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);

            Assert.AreEqual(res, "NURLİ JOL - BOLAŞAQQA BASTAR JOL");
        }


        [TestMethod]
        public void GetDictionary_SwitchDict_OnKaz()
        {
            var test = new TranslateKz(parhForDict, "CyrillicQazaq");

            var res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);

            Assert.AreEqual(res, "НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ");


            test.SetDictionary = "QazaqAqparat";

            res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);

            Assert.AreEqual(res, "NURLİ JOL - BOLAŞAQQA BASTAR JOL");
        }

        [TestMethod]
        public void GetDictionary_CyrillicQazaq_OutKaz()
        {
            var test = new TranslateKz(parhForDict, "CyrillicQazaq");

            var res = test.ConvertTo("НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ", DirectionType.OutKaz);

            Assert.AreEqual(res, "НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ");
        }

        [TestMethod]
        public void GetDictionary_QazaqAqparat_OutKaz()
        {
            var test = new TranslateKz(parhForDict, "QazaqAqparat");

            var res = test.ConvertTo("NURLİ JOL - BOLAŞAQQA BASTAR JOL", DirectionType.OutKaz);

            Assert.AreEqual(res, "НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ");
        }

        [TestMethod]
        public void GetDictionary_SwitchDict_OutKaz()
        {
            var test = new TranslateKz(parhForDict, "CyrillicQazaq");

            var res = test.ConvertTo("НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ", DirectionType.OutKaz);

            Assert.AreEqual(res, "НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ");


            test.SetDictionary = "QazaqAqparat";

            res = test.ConvertTo("NURLİ JOL - BOLAŞAQQA BASTAR JOL", DirectionType.OutKaz);

            Assert.AreEqual(res, "НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ");
        }
    }
}
