using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using System.IO;

namespace ProjectStickyFingers
{
	public class ContentHandler_Dialogue
	{
		private ContentManager _contentManager;

		private Dictionary<string, List<string>> _parsedDialogue;

		public ContentHandler_Dialogue(ContentManager contentManager)
		{
			_contentManager = contentManager;
		}


		public void LoadAllContent()
		{
			using (Stream stream = TitleContainer.OpenStream("Text/introText.txt"))
			using (StreamReader reader = new StreamReader(stream))
			{
				string key = string.Empty;
				string line = string.Empty;

				while (!reader.EndOfStream)
				{
					line += reader.ReadLine().ToString();

					if (line.EndsWith("=="))
					{
						key = line;
						line = string.Empty;
					}
				}
			}
		}


	}
}
