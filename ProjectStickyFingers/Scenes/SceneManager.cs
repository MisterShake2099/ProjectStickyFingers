using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.GUI;

namespace ProjectStickyFingers.Scenes
{
	class SceneManager
	{
		private static SceneManager _instance;
		private Scene currentScene;
		private Stack<GUI_Base> _guiStack = new Stack<GUI_Base>();


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

		public void PopGUI()
		{
			_guiStack.Pop();
		}

		public void PushGUI(GUI_Base newGui)
		{
			_guiStack.Push(newGui);
		}

	}
}
