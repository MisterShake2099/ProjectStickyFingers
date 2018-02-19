using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Sprites;


namespace ProjectStickyFingers.GraphicUserInterface
{
	class Widget_Panel : Widget
	{

		public Widget_Panel(string name, GUI parent, Texture2D texture, Vector2 position, Vector2 size, Vector2? offset, Vector2? origin)
			: base(name, parent, position, offset, size)
		{
			Sprite = new Sprite(texture, Position + Offset, Size);
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
