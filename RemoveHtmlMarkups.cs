public static string RemoveHtmlMarkups(string strParam)
{
    Regex regex = new Regex("\\<[^\\>]*\\>");
	strParam = regex.Replace(strParam, String.Empty);
	return strParam; 
}