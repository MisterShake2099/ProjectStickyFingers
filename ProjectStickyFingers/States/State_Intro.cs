using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.States
{
	public class State_Intro : State
	{
		private const string _continueText = "Press the 'any' key to continue...";

		private TextSprite _renderedText;
		private SpriteFont _font;
		private string _explanationText;
		private Rectangle _explanationBounds;
		private Button _continue;


		public State_Intro()
		{
			_font = ContentHandler.Instance.MenuScreen_Selections;

			using (Stream stream = TitleContainer.OpenStream("Text/introText.txt"))
			using (StreamReader reader = new StreamReader(stream))
			{
				while (!reader.EndOfStream)
				{
					_explanationText += (reader.ReadLine()).Replace("\\n", "\n");
				}
			}

			_explanationBounds = RenderedText.FullWindowRectangle();
			_explanationBounds.Inflate(-160, -90);

			_renderedText = new TextSprite(_font, _explanationText, Color.Gold, _explanationBounds, HorizontalAlignment.Center, VerticalAlignment.Top);

			_continue = new Button(_continueText, _font, new Vector2((Game1.WINDOW_WIDTH / 2) - (_font.MeasureString(_continueText).X / 2), Game1.WINDOW_HEIGHT - 75));
		}


		public override void Update(GameTime gameTime)
		{
			InputManager.Update();

			if (InputManager.AnyKeyPressed())
			{
				StateManager.ChangeState(new State_Game());
			}
		}


		public override void Draw(SpriteBatch spriteBatch)
		{
			_renderedText.Draw(spriteBatch);
			_continue.Draw(spriteBatch);
		}

	}
}
