using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ProjectStickyFingers
{
	public class ContentHandler_Dialogue
	{
		private ContentManager _contentManager;
		private Dictionary<string, string> _parsedDialogue = new Dictionary<string, string>();

		public ContentHandler_Dialogue(ContentManager contentManager)
		{
			_contentManager = contentManager;
		}


		public string GetDialogue(string key)
		{
			_parsedDialogue.TryGetValue(key, out string value);
			return value;
		}


		public void LoadAllContent()
		{
			XmlDocument document = new XmlDocument();
			document.Load("Text/introText.xml");

			string key = string.Empty;
			string value = string.Empty;

			foreach (XmlNode node in document["dialogues"].ChildNodes)
			{
				key = node["name"].InnerText;
				value = (node["text"].InnerText).Replace("\\n", "\n");

				_parsedDialogue.Add(key, value);
			}
		}


	}
}
