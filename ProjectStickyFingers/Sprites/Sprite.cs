using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers.Sprites
{
	public abstract class Sprite
	{
		public Vector2 _position { get; set; }
		public bool _isActive { get; set; }
		public Color _color { get; set; }

		public Sprite(){}

		public Sprite(Vector2 position, bool isActive = true)
		{
			_position = position;
			_isActive = isActive;
			_color = Color.White;
		}

		public abstract void Update(GameTime gameTime, Vector2 newPosition);

		public abstract void Draw(SpriteBatch spriteBatch);
	}
}
