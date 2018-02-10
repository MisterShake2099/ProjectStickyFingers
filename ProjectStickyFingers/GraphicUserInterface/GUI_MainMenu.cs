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
		Texture2D buttonTexture = ContentHandler.Instance.GetTexture2D("MenuScreen_StartButton");


		public GUI_MainMenu()
		{
			Widgets = InitializeWidgets();
			CurrentlySelectedWidget = 0;
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);
		}

		public override List<Widget> InitializeWidgets()
		{
			return new List<Widget>
			{
				new Widget_MenuButton(this, new Vector2(Game1.WINDOW_WIDTH / 2 - buttonTexture.Width / 2, Game1.WINDOW_HEIGHT / 2), buttonTexture, "StartButton"),
				new Widget_MenuButton(this, new Vector2(Game1.WINDOW_WIDTH / 2 - buttonTexture.Width / 2, Game1.WINDOW_HEIGHT / 2 + 100), buttonTexture, "OptionsButton"),
				new Widget_MenuButton(this, new Vector2(Game1.WINDOW_WIDTH / 2 - buttonTexture.Width / 2, Game1.WINDOW_HEIGHT / 2 + 200), buttonTexture, "QuitButton")
			};
		}

		public override void HandleWidgetActivated(Widget caller)
		{
			Widget found = Widgets.Find((Widget w) => { return w.Equals(caller); });

			switch (caller.Name)
			{
				case "StartButton":
					SceneManager.GetInstance().ChangeScene(new Scene_IntroText());
					break;
				case "OptionsButton":
					break;
				case "QuitButton":
					break;
			}
		}

	}
}
