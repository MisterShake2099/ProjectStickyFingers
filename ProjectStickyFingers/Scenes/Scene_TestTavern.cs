using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;
using ProjectStickyFingers.GraphicUserInterface;

namespace ProjectStickyFingers.Scenes
{
	class Scene_TestTavern : Scene
	{
		//private SpriteFont _font = ContentHandler.Instance.GetSpriteFont("Font_Romulus");
		private Sprite _guiFrameSprite;
		//private Texture2D _insideTavern;
		private Sprite _insideTavernSprite;


		public Scene_TestTavern()
		{
			_drawArea = new Rectangle(0, 0, Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT);

			_guiFrameSprite = new Sprite(ContentHandler.Instance.GetTexture2D("Game_GuiFrame"), new Point(0, 0));
			//_drawArea.Center.ToVector2() - new Vector2(_guiFrame.Width / 2, _guiFrame.Height / 2));

			//_insideTavern = ContentHandler.Instance.GetTexture2D("Game_TavernInside");
			//_insideTavernSprite = new Sprite(_insideTavern, new Vector2((_drawArea.Center.X) - (_insideTavern.Width / 2), (_drawArea.Center.Y) - (_insideTavern.Height / 2)));
			_insideTavernSprite = new Sprite(ContentHandler.Instance.GetTexture2D("Game_TavernInside"), new Point(0, 0));
		}

		public override void Update(GameTime gameTime)
		{

		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			//spriteBatch.Draw(_insideTavern, new Rectangle(_guiFrameSprite.Position.ToPoint(), _guiFrameSprite._texture.Bounds.Size), Color.White);
			_insideTavernSprite.Draw(spriteBatch);
			_guiFrameSprite.Draw(spriteBatch);
		}

		public override void Load()
		{
			SceneManager.GetInstance().PushGUI(new GUI_Gameplay());
		}

		public override void Unload()
		{
			base.Unload();
		}

	}
}
