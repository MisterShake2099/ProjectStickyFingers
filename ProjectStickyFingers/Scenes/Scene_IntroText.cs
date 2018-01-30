using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.Scenes
{
	class Scene_IntroText : Scene
	{
		private const string _continueText = "Press the 'any' key to continue...";

		private Button _continue;
		private Rectangle _explanationBounds;
		private string _explanationText;
		private SpriteFont _font;
		private TextSprite _renderedText;


		public Scene_IntroText()
		{
			_font = ContentHandler.Instance.GetSpriteFont("Font_Romulus");

			_explanationText = ContentHandler.Instance.GetDialogue("intro.explanation");
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
				SceneManager.ChangeScene(new Scene_Beginning());
			}
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			_renderedText.Draw(spriteBatch);
			_continue.Draw(spriteBatch);
		}

	}
}
