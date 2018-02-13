using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;
using ProjectStickyFingers.GraphicUserInterface;


namespace ProjectStickyFingers.Scenes
{
	class Scene_IntroText : Scene
	{
		private const string _continueText = "Press the 'any' key to continue...";

		//private Button _continue;
		private Rectangle _explanationBounds;
		private string _explanationText;
		private SpriteFont _font;
		private Sprite_Text _renderedText;


		public Scene_IntroText()
		{
			_font = ContentHandler.Instance.GetSpriteFont("Font_Romulus");

			_explanationText = ContentHandler.Instance.GetDialogue("intro.explanation");
			//_explanationBounds = RenderedText.FullWindowRectangle();
			_explanationBounds.Inflate(-160, -90);

			//_renderedText = new Sprite_Text(_font, _explanationText, Color.Gold, _explanationBounds, HorizontalAlignment.Center, VerticalAlignment.Top);

			//_continue = new Button(_continueText, _font, new Vector2((Game1.WINDOW_WIDTH / 2) - (_font.MeasureString(_continueText).X / 2), Game1.WINDOW_HEIGHT - 75));
		}

		public override void Update(GameTime gameTime)
		{
			if (InputManager.GetInstance().AnyKeyPressed())
			{
				SceneManager.GetInstance().ChangeScene(new Scene_TestTavern());
			}
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			_renderedText.Draw(spriteBatch);
			//_continue.Draw(spriteBatch);
		}

		public override void Load()
		{
			
		}

		public override void Unload()
		{
			//SceneManager.GetInstance().PopGUI();
		}
	}
}
