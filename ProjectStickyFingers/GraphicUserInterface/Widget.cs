using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectStickyFingers.Sprites;

namespace ProjectStickyFingers.GraphicUserInterface
{
	/* Widgets are meant to be GUI elements and other
	   similar objects that need to scale. */
	public abstract class Widget
	{
		protected GUI Parent { get; }
		protected Vector2 Position { get; }
		protected Vector2 Offset { get; set; }
		protected Vector2 Origin { get; set; }
		protected Vector2 Size { get; }
		protected bool IsSelected { get; set; }
		protected Sprite Sprite { get; set; }
		protected Rectangle WidgetArea { get; set; }

		public string Name { get; }
		public event WidgetEvent Activated;


		public Widget(string name, GUI parent, Vector2 position, Vector2? offset, Vector2? origin, Vector2? size)
		{
			Name = name;
			Parent = parent;
			Position = position;
			Offset = offset ?? Vector2.Zero;
			Origin = origin ?? position;
			Size = size ?? Vector2.Zero;
			IsSelected = false;

			WidgetArea = new Rectangle((Position + Offset).ToPoint(), Size.ToPoint() );
		}

		public virtual void Update(GameTime gameTime) { }

		public virtual void Draw(SpriteBatch spriteBatch)
		{
			Sprite.Draw(spriteBatch, Origin);
		}

		public void WidgetActivated(Widget w)
		{
			Activated?.Invoke(w);
		}

	}
}
