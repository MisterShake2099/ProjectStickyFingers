using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers
{
	// TODO: This class could be abstract eventually, allowing for creation
	// of sub GameContent that contains only needed assets for a particular scene.
	public class GameContent
	{
		public Texture2D SimpleTestHouse { get; set; }

		public GameContent(ContentManager content)
		{
			SimpleTestHouse = content.Load<Texture2D>("simpleTestHouse");
		}


	}
}
