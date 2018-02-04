using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;

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
			Selected += Parent.HandleWidgetSelected;
		}

		public override void Update(GameTime gameTime)
		{
			if (WidgetArea.Contains(InputManager.GetInstance().GetMousePosition()) && InputManager.GetInstance().MouseLeftPressed())
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
