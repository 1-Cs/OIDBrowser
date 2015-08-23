using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OIDBrowser
{
	class SyntaxErrorException : System.Exception
	{

	}
	class Morphy
	{

		public void readFile()
		{

			XmlReader xml = XmlReader.Create(@"c:\Source\1-xml\morphy-export-20110722.xml");
			char letter;
			bool error = false;
			Stack<String> backStack = new Stack<String>();
			for (letter = 'a'; letter <= 'z'; letter++)
			{
				XmlWriter writer = XmlWriter.Create(@"c:\Source\1-xml\morphy-export-20110722-" + letter + ".xml");
				while (true)
				{
					try
					{
						if (!xml.Read())
							break;
					}
					catch (XmlException e)
					{
						error = true;
						break;
					}
					switch (xml.NodeType)
					{
						case XmlNodeType.Element:
							if (!xml.IsEmptyElement)
								backStack.Push(xml.Name);
							writer.WriteStartElement(xml.Name);
							if (xml.HasAttributes)
							{
								xml.MoveToFirstAttribute();
								do
								{
									//writer.WriteStartAttribute(xml.Name);
									writer.WriteAttributeString(xml.Name, xml.Value);
								}
								while (xml.MoveToNextAttribute());
							}
							break;
						case XmlNodeType.Text:
							writer.WriteValue(xml.Value);
							break;
						case XmlNodeType.Attribute:
							break;
						case XmlNodeType.CDATA:
							writer.WriteCData(xml.Value);
							break;
						case XmlNodeType.Comment:
							writer.WriteComment(xml.Value);
							break;
						case XmlNodeType.EndElement:
							String nodeX = backStack.Pop();
							if (nodeX != xml.Name)
								throw new SyntaxErrorException();
							writer.WriteEndElement();
							break;
						case XmlNodeType.ProcessingInstruction:
							break;
						default:
							break;

					}
				}
				if (error)
					break;

			}
			xml.Close();
		}
	}
}
