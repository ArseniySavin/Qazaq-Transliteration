This app can help to translate kazakh words on latin. this Build may used in MSSQLServer and C# code.

So if you using MT message for banking operation or Posting messages for companies. You can send transliteration message on QAZAQ your partners.

<h2>Most popular translated</h2>
<b>Cyrillic-Qazaq</b> - This is translate used everywhere and every bank of country. Here used unicode 1251.<br/>
<b>Qazaq-Aqparat</b> - Sometimes national bank uses this translate. Here used unicode utf-8.

<h1>How to use</h1>

<h3>Use as SQL function:</h3>
<ol>
<li>Publish project on your SQLServer.</li>
<li>Check installed assembly.</li>
<li>You can call function set @Variable = dbo.TranslateOnCyrillicQazaq('SomeKazakhText') select @Variable</li>
</ol>

<h3>Use as C# methods:</h3>
<ol>
<li>Add reference on assembly.</li>
<li>Call static class InitializationDictionary var exString = InitializationDictionary.ConvertTo("SomeKazakhText", EnumTransliteType, EnumDirectionType);</li>
</ol>

With new version. Can add it as [nuget package](https://www.nuget.org/packages/Translate_KZ/1.0.0).

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

var test = new TranslateKz(parhPatForDict, "CyrillicQazaq");

var res = test.ConvertTo("НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ", DirectionType.OnKaz);
  
````
result: "НЎРЛЫ ЖОЛ - БОЛАШАЌЌА БАСТАР ЖОЛ"

<hr/>
*This app is overdue for Kazakhstan!
