using System;
using System.Collections.Generic;
using System.Xml;
public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        List<string> results = new List<string>();
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xml);

        //Display all the book titles.
        XmlNodeList elemList = doc.GetElementsByTagName("folder");

        for (int i = 0; i < elemList.Count; i++)
        {
            //Console.WriteLine(elemList[i].InnerXml);
            var attributeList = elemList[i].Attributes;
            foreach(XmlAttribute attr in attributeList)
            {
                var attrinuteValue = attr.Value;
                if (attrinuteValue.StartsWith(startingLetter.ToString()))
                    results.Add(attrinuteValue);
            }
        }

        return results;
    }

    public static IEnumerable<string> FolderNamesID(string xml, char startingLetter)
    {
        List<string> results = new List<string>();
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xml);

        //Display all the book titles.
        XmlNodeList elemList = doc.GetElementsByTagName("entry");

        for (int i = 0; i < elemList.Count; i++)
        {
            
            //Console.WriteLine(elemList[i].ParentNode.Attributes["Id"].Value);

            Console.WriteLine(elemList[i].InnerXml);
            var el = elemList[i].ChildNodes;
            foreach (XmlNode ell in elemList[i].ChildNodes)
            {
                Console.WriteLine(ell.GetAttribute("name"));
                Console.WriteLine(ell.InnerText);
            }
            //var attributeList = elemList[i].Attributes;
            //foreach (XmlAttribute attr in attributeList)
            //{
            //    var attrinuteValue = attr.Value;
            //    if (attrinuteValue.StartsWith(startingLetter.ToString()))
            //        results.Add(attrinuteValue);
            //}
        }

        return results;
    }

    public static void Main(string[] args)
    {
        //string xml =
        //    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
        //    "<folder name=\"c\">" +
        //        "<folder name=\"program files\">" +
        //            "<folder name=\"uninstall information\" />" +
        //        "</folder>" +
        //        "<folder name=\"users\" />" +
        //    "</folder>";

        String xml =
        "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
        "<log>\n" +
        "    <entry id=\"1\">\n" +
        "        <message>Application started</message>\n" +
        "    </entry>\n" +
        "    <entry id=\"2\">\n" +
        "        <message>Application ended</message>\n" +
        "    </entry>\n" +
        "</log>";

        foreach (string name in Folders.FolderNamesID(xml, 'u'))
            Console.WriteLine(name);
        Console.ReadLine();
    }
}