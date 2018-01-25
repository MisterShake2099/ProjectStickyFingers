using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers.Sprites
{
	class StaticSprite : Sprite
	{
		public Texture2D _texture { get; set; }

		public StaticSprite(Texture2D texture, Vector2 position) : base(position)
		{
			_texture = texture;
		}

		public void Move(Vector2 position)
		{
			_position = position;
		}

		public override void Update(GameTime gameTime, Vector2 newPosition)
		{
			Move(newPosition);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(_texture, _position, _color);
		}

	}
}
