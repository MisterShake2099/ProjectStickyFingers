using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers.Scenes
{
	class SceneManager
	{
		private static SceneManager _instance;
		private Scene currentScene;

		
		public static SceneManager GetInstance()
		{
			if (_instance == null)
			{
				_instance = new SceneManager();
			}
			return _instance;
		}

		public void Update(GameTime gameTime)
		{
			currentScene.Update(gameTime);
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			currentScene.Draw(spriteBatch);
		}

		public static void ChangeScene(Scene newScene)
		{
			if (_instance.currentScene != null)
			{
				// Unload currentScene
			}
			// Load newScene
			_instance.currentScene = newScene;
		}

	}
}
