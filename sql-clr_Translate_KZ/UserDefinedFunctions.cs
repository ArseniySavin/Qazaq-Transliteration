//------------------------------------------------------------------------------
// 
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using TranslateQazaq;

public partial class UserDefinedFunctions
{
    #region Translate on Qazak
    
    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOnQazakAqparat(string text) 
    {
            return InitializationDictionary.ConvertTo(text, TransliteType.QazaqAqparat, DirectionType.OnKaz);
    }

    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOnAbcNet(string text)
    {
        return InitializationDictionary.ConvertTo(text, TransliteType.AbcNet, DirectionType.OnKaz);
    }

    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOnGostB(string text)
    {
        return InitializationDictionary.ConvertTo(text, TransliteType.GostB, DirectionType.OnKaz);
    }

    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOnCommon(string text)
    {
        return InitializationDictionary.ConvertTo(text, TransliteType.Common, DirectionType.OnKaz);
    }

    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOnCyrillicQazaq(string text)
    {
        return InitializationDictionary.ConvertTo(text, TransliteType.CyrillicQazaq, DirectionType.OnKaz);
    } 
    #endregion

    #region Translate out Qazak

    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOutQazakAqparat(string text)
    {
        return InitializationDictionary.ConvertTo(text, TransliteType.QazaqAqparat, DirectionType.OutKaz);
    }

    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOutAbcNet(string text)
    {
        return InitializationDictionary.ConvertTo(text, TransliteType.AbcNet, DirectionType.OutKaz);
    }

    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOutGostB(string text)
    {
        return InitializationDictionary.ConvertTo(text, TransliteType.GostB, DirectionType.OutKaz);
    }

    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOutCommon(string text)
    {
        return InitializationDictionary.ConvertTo(text, TransliteType.Common, DirectionType.OutKaz);
    }

    /// <summary>
    /// 
    /// </summary>
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString TranslateOutCyrillicQazaq(string text)
    {
        return InitializationDictionary.ConvertTo(text, TransliteType.CyrillicQazaq, DirectionType.OutKaz);
    } 
    #endregion
}
