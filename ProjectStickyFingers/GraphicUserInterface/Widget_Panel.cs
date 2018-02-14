using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.GraphicUserInterface
{
	class Widget_Panel : Widget
	{
		private Texture2D _texture;


		public Widget_Panel(GUI parent, Vector2 position, Texture2D texture, string name)
			: base(parent, position, name)
		{
			_texture = texture;
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(_texture, Position, Color.White);

			base.Draw(spriteBatch);
		}

	}
}
