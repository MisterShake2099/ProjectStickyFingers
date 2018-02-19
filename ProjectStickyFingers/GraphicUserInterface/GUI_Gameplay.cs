using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.ContentHandlers;

namespace ProjectStickyFingers.GraphicUserInterface
{
	class GUI_Gameplay : GUI
	{
		private Texture2D _panelOne = ContentHandler.Instance.ColoredTexture(null);


		public GUI_Gameplay()
		{
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
				{ "PanelOne", new Widget_Panel("PanelOne", this, _panelOne, Vector2.Zero, new Vector2(300, 200), null, null ) }
			};
		}

	}
}
