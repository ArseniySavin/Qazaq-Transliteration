This app can help to translate kazakh words on latin. this Build may used in MSSQLServer and C# code.

So if you using MT message for banking operation or Posting messages for companies. You can send transliteration message on QAZAQ your partners.

<h2>Most popular translated</h2>
<b>GOST-569</b> - The official translate on e.gov. https://online.zakon.kz/Document/?doc_id=33613600#pos=1;-176.<br/>
<b>Cyrillic-Qazaq</b> - This is translate used everywhere and every bank of country. Here used unicode 1251.<br/>
<b>Qazaq-Aqparat</b> - Sometimes national bank uses this translate. Here used unicode utf-8.

<h1>How to use</h1>

<h3>Use as C# methods:</h3>
<ol>
<li>Add reference on assembly.</li>
<li>Call static class InitializationDictionary var exString = InitializationDictionary.ConvertTo("SomeKazakhText", EnumTransliteType, EnumDirectionType);</li>
</ol>

How to use new version:
You can add custome dictionary. Create new json file. Using for this template
````json
{
    "name": "<your name dictionary>", // for example CyrillicQazaq
    "title": "---",                   // description
    "dict_type": "dict",              // constant value
    "dict": {                         // dictionary
        "Key": "Value",
        ...
    }
}
````
Save file in your directory. And call method ConvertTo using example.
````C#
var parhPatForDict = "<exemple path for dict directory>"

var test = new TranslateKz(parhPatForDict, "GOST-569");

var res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);
  
````
result: "НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ"

<h3>Use as SQL function (Legacy! Not support):</h3>
<ol>
<li>Publish project on your SQLServer.</li>
<li>Check installed assembly.</li>
<li>You can call function set @Variable = dbo.TranslateOnCyrillicQazaq('SomeKazakhText') select @Variable</li>
</ol>


<hr/>
*This app is overdue for Kazakhstan!
