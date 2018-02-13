using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.ContentHandlers;

namespace ProjectStickyFingers.GraphicUserInterface
{
	class Widget_Button : Widget
	{
		private Texture2D _texture;


		public Widget_Button(GUI parent, Vector2 position, Texture2D texture, string name)
			: base(parent, position, name)
		{
			_texture = texture;
			WidgetArea = new Rectangle(position.ToPoint(), _texture.Bounds.Size);
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
			spriteBatch.Draw(_texture, new Rectangle(Position.ToPoint(), _texture.Bounds.Size), Color.White);

			if (IsSelected)
			{
				spriteBatch.Draw(ContentHandler.Instance.GetTexture2D("EmptyTexture"), new Rectangle(Position.ToPoint(), _texture.Bounds.Size), Color.White);
			}
		}

	}
}
