using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.GraphicUserInterface
{
	public abstract class Widget
	{
		protected GUI Parent { get; }
		protected Vector2 Position { get; }
		protected Rectangle WidgetArea { get; set; }
		//public event EventHandler Selected;
		public event WidgetEvent Selected;
		public string Name { get; }

		public Widget(GUI parent, Vector2 position, string name)
		{
			Parent = parent;
			Position = position;
			Name = name;
		}

		public virtual void Update(GameTime gameTime){ }

		public virtual void Draw(SpriteBatch spriteBatch) { }

		public void WidgetSelected(Widget w)
		{
			Selected?.Invoke(w);
		}

	}
}
