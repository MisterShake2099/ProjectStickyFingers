using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers
{
	public class Sprite
	{
		protected Texture2D _texture;

		public Sprite(Texture2D texture)
		{
			_texture = texture;
		}

		public virtual void Update() {}

		public virtual void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(_texture, new Vector2(0, 0), Color.White);
		}


	}
}
