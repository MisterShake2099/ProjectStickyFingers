using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.States
{
	public class StateManager
	{
		private static StateManager _instance;

		private static State _currentScene;
		private static State _nextScene;
		private static bool _sceneChange = false;

		public StateManager(){}


		public static StateManager GetInstance()
		{
			if (_instance == null)
			{
				_instance = new StateManager();
			}
			return _instance;
		}

		public static void ChangeState(State targetScene)
		{
			_nextScene = targetScene;
			_sceneChange = true;
		}

		public static void Update(GameTime gameTime)
		{
			if (_sceneChange)
			{
				_currentScene = _nextScene;
				_sceneChange = false;
			}

			_currentScene.Update(gameTime);
		}

		public static void Draw(SpriteBatch spriteBatch)
		{
			_currentScene.Draw(spriteBatch);
		}

	}
}
