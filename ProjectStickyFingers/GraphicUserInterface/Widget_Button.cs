using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.GraphicUserInterface
{
	class Widget_Button : Widget
	{
		public Widget_Button(string name, GUI parent, Texture2D texture, Vector2 position, Vector2? offset, Vector2? origin, Vector2? size)
			: base(name, parent, position, offset, origin, size)
		{
			Sprite = new Sprite(texture, Position + Offset, Size);

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
