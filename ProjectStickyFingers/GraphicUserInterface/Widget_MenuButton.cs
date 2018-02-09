using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;

namespace ProjectStickyFingers.GraphicUserInterface
{
	class Widget_MenuButton : Widget
	{
		private Texture2D _texture;


		public Widget_MenuButton(GUI parent, Vector2 position, Texture2D texture, string name)
			: base(parent, position, name)
		{
			_texture = texture;
			WidgetArea = new Rectangle(position.ToPoint(), _texture.Bounds.Size);
			Selected += Parent.HandleWidgetSelected;
		}

		public override void Update(GameTime gameTime)
		{
			if (WidgetArea.Contains(InputManager.GetInstance().MousePosition()) && InputManager.GetInstance().MouseLeftPressed())
			{
				WidgetSelected(this);
			}
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(_texture, new Rectangle(Position.ToPoint(), _texture.Bounds.Size), Color.White);
		}

	}
}
