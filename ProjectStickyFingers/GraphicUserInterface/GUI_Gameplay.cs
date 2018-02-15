using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.GraphicUserInterface
{
	class GUI_Gameplay : GUI
	{
		private Texture2D _sideInfo;
		private Texture2D _guiFrame;

		public GUI_Gameplay()
		{
			_sideInfo = ContentHandler.Instance.GetTexture2D("GUI_sideInfo");

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
				{ "SideInfo", new Widget_Panel(this, new Vector2(0, 300), _sideInfo, "SideInfo") }
			};
		}

	}
}
