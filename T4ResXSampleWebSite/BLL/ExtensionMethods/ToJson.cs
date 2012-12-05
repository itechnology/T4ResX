using System.Web.Script.Serialization;

public static partial class ExtensionMethods
{
    static readonly JavaScriptSerializer JavaScriptSerializer =  new JavaScriptSerializer();

    public static string ToJson(this object item)
    {
        return JavaScriptSerializer.Serialize(item);
    }
}