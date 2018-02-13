using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.GraphicUserInterface
{
	class GUI_Gameplay : GUI
	{
		private Texture2D _sideInfo;
		private Texture2D _tavernInside;

		public GUI_Gameplay()
		{
			_sideInfo = ContentHandler.Instance.GetTexture2D("GUI_sideInfo");
			_tavernInside = ContentHandler.Instance.GetTexture2D("Game_TavernInside");

			Widgets = InitializeWidgets();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(_tavernInside, new Rectangle(0, 0, Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT), Color.White);
			base.Draw(spriteBatch);
		}

		public override void HandleWidgetActivated(Widget caller)
		{
			
		}

		public override Dictionary<string, Widget> InitializeWidgets()
		{
			return new Dictionary<string, Widget>
			{
				{ "SideInfo", new Widget_Button(this, new Vector2(0, 300), _sideInfo, "SideInfo") },
			};
		}

	}
}
