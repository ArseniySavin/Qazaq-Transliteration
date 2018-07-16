using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translate_KZ;

namespace Translate_KZ_Test
{
    [TestClass]
    public class Translate_KZ_Test
    {
        string _pathForDict = Directory.GetCurrentDirectory();

        [TestMethod]
        public void GetDictionary_CyrillicQazaq_OnKaz()
        {
            var test = new TranslateKz(_pathForDict, "CyrillicQazaq");

            var res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);

            Assert.AreEqual(res, "НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ");
        }

        [TestMethod]
        public void GetDictionary_QazaqAqparat_OnKaz()
        {
            var test = new TranslateKz(_pathForDict, "QazaqAqparat");

            var res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);

            Assert.AreEqual(res, "NURLİ JOL - BOLAŞAQQA BASTAR JOL");
        }

        [TestMethod]
        public void GetDictionary_GOST569_OnKaz()
        {
            var test = new TranslateKz(_pathForDict, "GOST-569");

            var res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);

            Assert.AreEqual(res, "NURLY JOL - BOLAShAQQA BASTAR JOL");
        }


        [TestMethod]
        public void GetDictionary_SwitchDict_OnKaz()
        {
            var test = new TranslateKz(_pathForDict, "CyrillicQazaq");

            var res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);

            Assert.AreEqual(res, "НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ");


            test.SetDictionary = "QazaqAqparat";

            res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);

            Assert.AreEqual(res, "NURLİ JOL - BOLAŞAQQA BASTAR JOL");
        }

        [TestMethod]
        public void GetDictionary_CyrillicQazaq_OutKaz()
        {
            var test = new TranslateKz(_pathForDict, "CyrillicQazaq");

            var res = test.ConvertTo("НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ", DirectionType.OutKaz);

            Assert.AreEqual(res, "НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ");
        }

        [TestMethod]
        public void GetDictionary_QazaqAqparat_OutKaz()
        {
            var test = new TranslateKz(_pathForDict, "QazaqAqparat");

            var res = test.ConvertTo("NURLİ JOL - BOLAŞAQQA BASTAR JOL", DirectionType.OutKaz);

            Assert.AreEqual(res, "НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ");
        }

        [TestMethod]
        public void GetDictionary_SwitchDict_OutKaz()
        {
            var test = new TranslateKz(_pathForDict, "CyrillicQazaq");

            var res = test.ConvertTo("НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ", DirectionType.OutKaz);

            Assert.AreEqual(res, "НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ");


            test.SetDictionary = "QazaqAqparat";

            res = test.ConvertTo("NURLİ JOL - BOLAŞAQQA BASTAR JOL", DirectionType.OutKaz);

            Assert.AreEqual(res, "НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ");
        }

        [TestMethod]
        public void GetDictionary_GOST_569_OnKaz()
        {
            var test = new TranslateKz(_pathForDict, "GOST-569");

            string text = @"Аа Әә Бб Вв Гг Ғғ Дд Ее Ёё Жж Зз Ии Йй Кк Ққ Лл Мм Нн Ңң Оо Өө Пп Рр Сс Тт Уу Ұұ Үү Фф Хх Һһ Цц Чч Шш Щщ Ъъ Ыы Іі Ьь Ээ Юю Яя";

            var res = test.ConvertTo(text, DirectionType.OnKaz);

            Assert.AreEqual(res, @"Aa Áá Bb Vv Gg Ǵǵ Dd Ee  Jj Zz Iı Iı Kk Qq Ll Mm Nn Ńń Oo Óó Pp Rr Ss Tt Ýý Uu Úú Ff Hh Hh  Chch Shsh   Yy Ii    ");
        }

        [TestMethod]
        public void GetDictionary_BigText_OnKaz()
        {
            var test = new TranslateKz(_pathForDict, "GOST-569");

            string text = @"Ішкі диаметрі 40 мм, қабырғы қалыңдығы 4 мм жіксіз болат құбыр. Шаруашылық - ауыз суы, кәріздік және жылыту жүйелеріне тағайындауға арналған. Tапсырыс берушінің талаптары - бір топтағы құбрларды жеткізгенде құбырлардың ішкі жжәне сыртқы беті тегіс болуы керек. Құбырладың сыртқы, ішкі және тік қойылған кесіндісінің бетінде үлкейту құралдарының көмегінсз көзге түсетін копіршіктер, саңылаулар, қуыстар, басқа да қосындылардың болу рұқсат етілмейді. Эляим.";

            var res = test.ConvertTo(text, DirectionType.OnKaz);

            Assert.AreEqual(res, @"Ishki diametri 40 mm, qabyrǵy qalyńdyǵy 4 mm jiksiz bolat qubyr. Sharýashylyq - aýyz sýy, kárizdik jáne jylytý júıelerine taǵaıyndaýǵa arnalǵan. Tapsyrys berýshiniń talaptary - bir toptaǵy qubrlardy jetkizgende qubyrlardyń ishki jjáne syrtqy beti tegis bolýy kerek. Qubyrladyń syrtqy, ishki jáne tik qoıylǵan kesindisiniń betinde úlkeıtý quraldarynyń kómeginsz kózge túsetin kopirshikter, sańylaýlar, qýystar, basqa da qosyndylardyń bolý ruqsat etilmeıdi. lim.");
        }
    }
}
