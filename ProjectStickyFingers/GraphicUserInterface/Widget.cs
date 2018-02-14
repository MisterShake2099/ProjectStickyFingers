using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.GraphicUserInterface
{
	public abstract class Widget
	{
		protected GUI Parent { get; }
		protected Vector2 Position { get; }
		protected bool IsSelected { get; set; }
		public Rectangle WidgetArea { get; set; }
		public event WidgetEvent Activated;
		public string Name { get; }

		public Widget(GUI parent, Vector2 position, string name)
		{
			Parent = parent;
			Position = position;
			Name = name;
			IsSelected = false;
		}

		public virtual void Update(GameTime gameTime){}

		public virtual void Draw(SpriteBatch spriteBatch){}

		public void WidgetActivated(Widget w)
		{
			Activated?.Invoke(w);
		}

	}
}
