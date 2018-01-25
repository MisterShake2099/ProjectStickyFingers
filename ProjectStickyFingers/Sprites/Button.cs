using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers.Sprites
{
	class Button : Sprite
	{
		private string _buttonText;
		private SpriteFont _spriteFont;

		public Button(string buttonText, SpriteFont spriteFont, Vector2 position, bool isActive = true) : base(position, isActive)
		{
			_buttonText = buttonText;
			_spriteFont = spriteFont;
		}

		public Vector2 GetButtonSize()
		{
			return _spriteFont.MeasureString(_buttonText);
		}

		public override void Update(GameTime gameTime) {}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(_spriteFont, _buttonText, _position, _color);
		}

	}
}
