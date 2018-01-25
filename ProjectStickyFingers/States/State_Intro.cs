using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ProjectStickyFingers.States
{
	public class State_Intro : State
	{
		private const string _continueText = "Hit 'Enter' to continue...";

		private RenderedText _renderedText;
		private SpriteFont _font;
		private string _explanationText;
		private Rectangle _explanationBounds;
		private Button _continue;
		private float _timer = 0;


		public State_Intro()
		{
			_font = ContentHandler.Instance.MenuScreen_Selections;
			_explanationText = "Project: Sticky Fingers is the development name " +
								"for this game about legitimate business dealings.\n\n" +
								"In it, you assume the role of a humble merchant. " +
								"One that happens to specialize in goods with an " +
								"``interesting`` history of ownership.\n\n" +
								"Make deals, establish clients, acquire inventory, and " +
								"evade the grasp of legal sticklers that don't appreciate " +
								"your novel take on entrepreneurship.\n\n" +
								"Maybe you'll rule a brightness-challenged market " +
								"some day... stranger things have happened.";
			_explanationBounds = RenderedText.FullWindowRectangle();
			_explanationBounds.Inflate(-160, -90);

			_renderedText = new RenderedText(_font, _explanationText, Color.Gold, _explanationBounds, HorizontalAlignment.Center, VerticalAlignment.Top);

			_continue = new Button(_continueText, _font, new Vector2((Game1.WINDOW_WIDTH / 2) - (_font.MeasureString(_continueText).X / 2), Game1.WINDOW_HEIGHT - 75));
		}


		public override void Update(GameTime gameTime)
		{
			InputManager.Update();

			_timer += (float)gameTime.ElapsedGameTime.TotalSeconds;
			if (_timer >= 1f)
			{
				_continue._isActive = !_continue._isActive;
				_timer = 0f;
			}

			if (InputManager.KeyPressed(Keys.Enter))
			{
				StateManager.ChangeState(new State_Game());
			}
		}


		public override void Draw(SpriteBatch spriteBatch)
		{
			_renderedText.Draw(spriteBatch);

			if (_continue._isActive)
			{
				_continue.Draw(spriteBatch);
			}
		}

	}
}
