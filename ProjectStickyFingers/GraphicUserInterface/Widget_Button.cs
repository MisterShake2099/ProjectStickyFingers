using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.ContentHandlers;
using ProjectStickyFingers.Sprites;

namespace ProjectStickyFingers.GraphicUserInterface
{
	class Widget_Button : Widget
	{
		private Sprite _sprite;


		public Widget_Button(GUI parent, Vector2 position, Texture2D texture, string name)
			: base(parent, position, name)
		{
			_sprite = new Sprite(texture, position);
			WidgetArea = _sprite.RenderBounds;
			Activated += Parent.HandleWidgetActivated;
		}

		public override void Update(GameTime gameTime)
		{
			IsSelected = (WidgetArea.Contains(InputManager.GetInstance().MousePosition()));

			if (IsSelected && InputManager.GetInstance().MouseLeftPressed())
			{
				WidgetActivated(this);
			}
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			_sprite.Draw(spriteBatch);

			if (IsSelected)
			{
				spriteBatch.Draw(ContentHandler.Instance.GetTexture2D("EmptyTexture"), _sprite.RenderBounds, Color.White);
			}
		}

	}
}
