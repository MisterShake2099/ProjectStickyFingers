using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers
{
	class SceneManager
	{
		private Scene _currentScene;
		private Scene _nextScene;
		private bool _sceneChange = false;


		public SceneManager(){}


		public void LoadScene(Scene sceneToLoad)
		{
			_nextScene = sceneToLoad;
			_sceneChange = true;
		}


		public void Update(GameTime gameTime)
		{
			if (_sceneChange)
			{
				_currentScene = _nextScene;
				_sceneChange = false;
			}

			_currentScene.Update(gameTime);
		}


		public void Draw(SpriteBatch spriteBatch)
		{
			_currentScene.Draw(spriteBatch);
		}

	}

}
