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

		private string _introExplanation;
		private SpriteFont _font;
		private Sprite_Text _renderedText;


		public Scene_IntroText()
		{
			_font = ContentHandler.Instance.GetSpriteFont("Font_Romulus");

			_introExplanation = ContentHandler.Instance.GetDialogue("intro.explanation");

			_renderedText = new Sprite_Text(new Vector2(0, 0), new Vector2(Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT), _font, _introExplanation, HorizontalAlignment.Center, VerticalAlignment.Top, Color.Gold);

			//_continue = new Button(_continueText, _font, new Vector2((Game1.WINDOW_WIDTH / 2) - (_font.MeasureString(_continueText).X / 2), Game1.WINDOW_HEIGHT - 75));
		}

		public override void Update(GameTime gameTime)
		{
			if (InputManager.Instance.AnyKeyPressed())
			{
				SceneManager.Instance.ChangeScene(new Scene_Test());
			}
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			//_renderedText.Draw(spriteBatch);
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
