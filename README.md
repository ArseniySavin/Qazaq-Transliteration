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
<hr/>
*This app is overdue for Kazakhstan!
