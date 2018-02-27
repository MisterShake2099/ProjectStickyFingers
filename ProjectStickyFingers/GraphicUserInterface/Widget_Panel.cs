using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.GraphicUserInterface
{
	class Widget_Panel : Widget
	{
		private SpriteFont _spriteFont = ContentHandler.Instance.GetSpriteFont("Font_Romulus");

		public Widget_Panel(string name, GUI parent, Texture2D texture, Vector2 position, Vector2 size, Vector2? offset)
			: base(name, parent, position, offset, size)
		{
			Sprite = new Sprite(texture, Position + Offset, Size);
		}

		public Widget_Panel(string name, GUI parent, string text, Vector2 position, Vector2 size, Vector2? offset)
			: base(name, parent, position, offset, size)
		{
			Sprite = new Sprite_Text(Position + Offset, Size, _spriteFont, text, HorizontalAlignment.Left, VerticalAlignment.Top, Color.Black);
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);
		}

	}
}
