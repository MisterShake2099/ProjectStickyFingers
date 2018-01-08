using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers
{
	class Sprite
	{
		private Texture2D texture;

		public Sprite(Texture2D texture)
		{
			this.texture = texture;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, new Vector2(100, 100), Color.White);
		}


	}
}
