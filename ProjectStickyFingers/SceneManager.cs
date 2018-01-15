using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers
{
	class SceneManager
	{
		private Scene _currentScene;
		private Scene _nextScene;


		public SceneManager(){}


		public void LoadScene(Scene sceneToLoad)
		{
			_nextScene = sceneToLoad;
		}


		public void Update()
		{
			_currentScene = _nextScene;
		}


		public void Draw(SpriteBatch spriteBatch)
		{
			_currentScene.Draw(spriteBatch);
		}

	}

}
