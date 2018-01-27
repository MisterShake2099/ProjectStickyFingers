using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.States
{
	class State_StartMenu : State
	{
		enum OnButton { StartButton, OptionsButton, ExitButton }

		private const string TITLE_STRING = "Project: Sticky Fingers";
		private const string START_STRING = "Start";
		private const string OPTIONS_STRING = "Options";
		private const string EXIT_STRING = "Exit";
		private SpriteFont _title;
		private SpriteFont _selections;
		private Texture2D _selector;
		private Color _textColor = Color.Gold;
		private Vector2 _titleDimensions;
		
		private Button _titleButton;

		private Button _startButton;
		private Button _optionsButton;
		private Button _exitButton;

		private OnButton _onButton = OnButton.StartButton;
		private Button _currentButton;
		private StaticSprite _selectorSprite;


		public State_StartMenu()
		{
			StateName = "StartMenu";

			_title = ContentHandler.Instance.GetSpriteFont("MenuScreen_Title");
			_selections = ContentHandler.Instance.GetSpriteFont("MenuScreen_Selections");
			_selector = ContentHandler.Instance.GetTexture2D("MenuScreen_Selector");

			_titleDimensions = _title.MeasureString(TITLE_STRING);

			// TODO: title shouldn't stay a button, probably
			_titleButton = new Button(TITLE_STRING, _title, new Vector2((Game1.WINDOW_WIDTH / 2) - (_titleDimensions.X / 2), Game1.WINDOW_HEIGHT / 3))
			{
				_color = _textColor
			};

			_startButton = new Button(START_STRING, _selections, new Vector2(Game1.WINDOW_WIDTH / 2 - 35, Game1.WINDOW_HEIGHT / 2))
			{
				_color = _textColor
			};
			_optionsButton = new Button(OPTIONS_STRING, _selections, new Vector2(Game1.WINDOW_WIDTH / 2 - 35, Game1.WINDOW_HEIGHT / 2 + 50))
			{
				_color = _textColor
			};
			_exitButton = new Button(EXIT_STRING, _selections, new Vector2(Game1.WINDOW_WIDTH / 2 - 35, Game1.WINDOW_HEIGHT / 2 + 100))
			{
				_color = _textColor
			};

			_selectorSprite = new StaticSprite(_selector, Vector2.Zero)
			{
				_color = _textColor
			};

			_currentButton = _startButton;
		}

		public override void Update(GameTime gameTime)
		{
			InputManager.Update();

			if (InputManager.KeyPressed(Keys.Enter))
			{
				switch (_onButton)
				{
					case OnButton.StartButton:
						StateManager.ChangeState(new State_Intro());
						break;
					case OnButton.OptionsButton:
						// Change to Options scene or hover window.
						break;
					case OnButton.ExitButton:
						// Exit game.
						break;
				}
			}

			if (InputManager.KeyPressed(Keys.S))
			{
				_onButton += 1;
				if (_onButton > OnButton.ExitButton)
				{
					_onButton = OnButton.StartButton;
				}
			}

			if (InputManager.KeyPressed(Keys.W))
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
				{
					_currentButton = _startButton;
					break;
				}
				case OnButton.OptionsButton:
				{
					_currentButton = _optionsButton;
					break;
				}
				case OnButton.ExitButton:
				{
					_currentButton = _exitButton;
					break;
				}
			}

			_selectorSprite.Update(gameTime, new Vector2(_currentButton._position.X - 50,
														 _currentButton._position.Y + (_currentButton.GetButtonSize().Y / 2 ) - (_selectorSprite._texture.Height / 2) ));
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			_titleButton.Draw(spriteBatch);
			_startButton.Draw(spriteBatch);
			_optionsButton.Draw(spriteBatch);
			_exitButton.Draw(spriteBatch);

			//spriteBatch.Draw(_selector, _selectorPosition, Color.Gold);
			_selectorSprite.Draw(spriteBatch);

			//base.Draw(spriteBatch);
		}

	}
}
