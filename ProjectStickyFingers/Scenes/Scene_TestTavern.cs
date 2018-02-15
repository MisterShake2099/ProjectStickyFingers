using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;
using ProjectStickyFingers.GraphicUserInterface;

namespace ProjectStickyFingers.Scenes
{
	class Scene_TestTavern : Scene
	{
		private Sprite _castleTown;

		public Scene_TestTavern()
		{
			_castleTown = new Sprite(ContentHandler.Instance.GetTexture2D("CastleTown"), Vector2.Zero, new Vector2(Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT) );
		}


		public override void Update(GameTime gameTime){}

		public override void Draw(SpriteBatch spriteBatch)
		{
			_castleTown.Draw(spriteBatch);
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
