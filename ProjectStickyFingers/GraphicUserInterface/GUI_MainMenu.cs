using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Scenes;
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
				{ "StartButton", new Widget_Button(this, new Vector2(Game1.WINDOW_WIDTH / 2 - _buttonTexture.Width / 2, Game1.WINDOW_HEIGHT / 2), _buttonTexture, "StartButton") },
				{ "OptionsButton", new Widget_Button(this, new Vector2(Game1.WINDOW_WIDTH / 2 - _buttonTexture.Width / 2, Game1.WINDOW_HEIGHT / 2 + 100), _buttonTexture, "OptionsButton") },
				{ "QuitButton", new Widget_Button(this, new Vector2(Game1.WINDOW_WIDTH / 2 - _buttonTexture.Width / 2, Game1.WINDOW_HEIGHT / 2 + 200), _buttonTexture, "QuitButton") },
			};
		}

		public override void HandleWidgetActivated(Widget caller)
		{
			switch (caller.Name)
			{
				case "StartButton":
					SceneManager.GetInstance().ChangeScene(new Scene_TestTavern());
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
