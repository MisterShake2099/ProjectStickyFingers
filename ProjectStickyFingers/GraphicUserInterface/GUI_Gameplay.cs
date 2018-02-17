using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.Sprites;

namespace ProjectStickyFingers.GraphicUserInterface
{
	class GUI_Gameplay : GUI
	{
		private GlobalValues _globalValues;
		private Texture2D _panelOne;


		public GUI_Gameplay()
		{
			_globalValues = GlobalValues.Instance;
			_panelOne = _globalValues.MakeGraybox(_globalValues.TopLeftAnchor, new Vector2(300, 200));

			Widgets = InitializeWidgets();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);
		}

		public override void HandleWidgetActivated(Widget caller)
		{
			
		}

		public override Dictionary<string, Widget> InitializeWidgets()
		{
			return new Dictionary<string, Widget>
			{
				{ "PanelOne", new Widget_Panel(this, new Vector2(0, 300), _panelOne, "PanelOne") }
			};
		}

	}
}
