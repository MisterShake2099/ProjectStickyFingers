using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers
{
	// TODO: This class could be abstract eventually, allowing for creation
	// of sub GameContent that contains only needed assets for a particular scene.
	public class GameContent
	{
		public Texture2D AName { get; set; }

		public GameContent(ContentManager contentManager)
		{
			AName = contentManager.Load<Texture2D>("Name");
		}


	}
}
