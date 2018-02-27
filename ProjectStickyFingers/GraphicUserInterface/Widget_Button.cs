using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.GraphicUserInterface
{
	class Widget_Button : Widget
	{
		private SpriteFont _spriteFont = ContentHandler.Instance.GetSpriteFont("Font_Romulus");

		public Widget_Button(string name, GUI parent, Texture2D texture, Vector2 position, Vector2? offset, Vector2? size)
			: base(name, parent, position, offset, size)
		{
			Sprite = new Sprite(texture, Position + Offset, Size);

			Activated += Parent.HandleWidgetActivated;
		}

		public Widget_Button(string name, GUI parent, string text, Vector2 position, Vector2? offset, Vector2? size)
			: base(name, parent, position, offset, size)
		{
			Sprite = new Sprite_Text(Position + Offset, Size, _spriteFont, text, HorizontalAlignment.Center, VerticalAlignment.Center, Color.Black);

			Activated += Parent.HandleWidgetActivated;
		}

		public override void Update(GameTime gameTime)
		{
			IsSelected = (WidgetArea.Contains(InputManager.Instance.MousePosition()));

			if (IsSelected && InputManager.Instance.MouseLeftPressed())
			{
				WidgetActivated(this);
			}
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);

			if (IsSelected)
			{
				spriteBatch.Draw(ContentHandler.Instance.ColoredTexture(Color.Black, 150), WidgetArea, Color.White);
			}
		}

	}
}
