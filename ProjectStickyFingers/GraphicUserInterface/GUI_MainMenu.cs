using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Scenes;
using ProjectStickyFingers.Globals;
using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.GraphicUserInterface
{
	class GUI_MainMenu : GUI
	{
		private Texture2D _buttonTexture;


		public GUI_MainMenu()
		{
			_buttonTexture = ContentHandler.Instance.GetTexture2D("MenuScreen_StartButton");

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

		public override Dictionary<string, Widget> InitializeWidgets()
		{
			return new Dictionary<string, Widget>
			{
				{ "StartButton", new Widget_Button("StartButton", this, _buttonTexture, GlobalValues.Instance.MidAnchor,
													Vector2.Zero, new Vector2(_buttonTexture.Width / 2, _buttonTexture.Height / 2), new Vector2(100f, 50f) ) },

				{ "OptionsButton", new Widget_Button("OptionsButton", this, _buttonTexture, GlobalValues.Instance.MidAnchor,
													 new Vector2(0, 100), new Vector2(_buttonTexture.Width / 2, _buttonTexture.Height / 2), new Vector2(100f, 50f) ) },

				{ "QuitButton", new Widget_Button("QuitButton", this, _buttonTexture, GlobalValues.Instance.MidAnchor,
												  new Vector2(0, 200), new Vector2(_buttonTexture.Width / 2, _buttonTexture.Height / 2), new Vector2(100f, 50f) ) }
			};
		}

		public override void HandleWidgetActivated(Widget caller)
		{
			switch (caller.Name)
			{
				case "StartButton":
					SceneManager.Instance.ChangeScene(new Scene_Test());
					break;
				case "OptionsButton":
					break;
				case "QuitButton":
					_inputManager.Quit();
					break;
			}
		}

	}
}
