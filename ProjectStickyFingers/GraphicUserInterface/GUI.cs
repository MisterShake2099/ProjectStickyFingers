using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectStickyFingers.Globals;

namespace ProjectStickyFingers.GraphicUserInterface
{
	public delegate void WidgetEvent(Widget caller);

	public abstract class GUI
	{
		private enum _state { STATE, STATE2 }
		private Vector2 _position { get; set; }
		protected InputManager _inputManager { get; }
		protected Dictionary<string, Widget> Widgets { get; set; }


		public GUI()
		{
			_inputManager = InputManager.GetInstance();
		}
		
		public virtual void Update(GameTime gameTime)
		{
			
			foreach (Widget widget in Widgets.Values)
			{
				widget.Update(gameTime);
			}
		}

		public virtual void Draw(SpriteBatch spriteBatch)
		{
			foreach (Widget widget in Widgets.Values)
			{
				widget.Draw(spriteBatch);
			}
		}

		public abstract Dictionary<string, Widget> InitializeWidgets();

		public abstract void HandleWidgetActivated(Widget caller);

	}
}
