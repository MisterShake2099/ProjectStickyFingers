using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;
using ProjectStickyFingers.GraphicUserInterface;

namespace ProjectStickyFingers.Scenes
{
	class Scene_TestTavern : Scene
	{
		private Sprite _insideTavernSprite;


		public Scene_TestTavern()
		{
			_insideTavernSprite = new Sprite(ContentHandler.Instance.GetTexture2D("Game_TavernInside"), new Vector2(28, 28), new Vector2(Game1.WINDOW_WIDTH - 28, Game1.WINDOW_HEIGHT - 28) );
		}

		public override void Update(GameTime gameTime)
		{

		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			_insideTavernSprite.Draw(spriteBatch);
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
