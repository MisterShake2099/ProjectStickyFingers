using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;
using ProjectStickyFingers.GraphicUserInterface;


namespace ProjectStickyFingers.Scenes
{
	class Scene_StartMenu : Scene
	{
		private const string TITLE_STRING = "Project: Sticky Fingers";

		private SpriteFont _title;
		private Vector2 _titleDimensions;

		private Button _titleButton;
		
		
		public Scene_StartMenu()
		{
			_drawArea = new Rectangle(0, 0, Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT);

			_title = ContentHandler.Instance.GetSpriteFont("Title_Romulus");

			_titleDimensions = _title.MeasureString(TITLE_STRING);

			//TODO: title shouldn't stay a button
			_titleButton = new Button(TITLE_STRING, _title, new Vector2((Game1.WINDOW_WIDTH / 2) - (_titleDimensions.X / 2), Game1.WINDOW_HEIGHT / 3))
			{
				_color = Color.Gold
			};
		}

		public override void Update(GameTime gameTime)
		{
			/*
			if (InputManager.GetInstance().KeyPressed(Keys.S))
			{
				_onButton += 1;
				if (_onButton > OnButton.ExitButton)
				{
					_onButton = OnButton.StartButton;
				}
			}

			if (InputManager.GetInstance().KeyPressed(Keys.W))
			{
				_onButton -= 1;
				if (_onButton < OnButton.StartButton)
				{
					_onButton = OnButton.ExitButton;
				}
			}

			switch (_onButton)
			{
				case OnButton.StartButton:
					_currentButton = _startButton;
					break;
				case OnButton.OptionsButton:
					_currentButton = _optionsButton;
					break;
				case OnButton.ExitButton:
					_currentButton = _exitButton;
					break;
			}
			*/
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			_titleButton.Draw(spriteBatch);
		}

		public override void Load()
		{
			SceneManager.GetInstance().PushGUI(new GUI_MainMenu());
		}

		public override void Unload()
		{
			base.Unload();
		}

	}
}
