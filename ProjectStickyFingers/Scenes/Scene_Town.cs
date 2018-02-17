using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.GraphicUserInterface;

namespace ProjectStickyFingers.Scenes
{
	class Scene_Town : Scene
	{

		public Scene_Town()
		{
			_drawArea = new Rectangle(0, 0, Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT);
		}

		public override void Update(GameTime gameTime)
		{

		}

		public override void Draw(SpriteBatch spriteBatch)
		{

		}

		public override void Load()
		{
			SceneManager.Instance.PushGUI(new GUI_Gameplay());
		}

		public override void Unload()
		{
			base.Unload();
		}

	}
}
