using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.GraphicUserInterface;

namespace ProjectStickyFingers.Scenes
{
	class SceneManager
	{
		private static SceneManager _instance;
		private Scene currentScene;
		private Stack<GUI> _guiStack = new Stack<GUI>();


		public static SceneManager Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new SceneManager();
				}
				return _instance;
			}
		}
		public void SetInstance() { }

		public void Update(GameTime gameTime)
		{
			currentScene.Update(gameTime);

			if (_guiStack.Count > 0)
			{
				_guiStack.Peek().Update(gameTime);
			}
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			currentScene.Draw(spriteBatch);
			
			foreach (GUI gui in _guiStack)
			{
				gui.Draw(spriteBatch);
			}
		}

		public void ChangeScene(Scene newScene)
		{
			if (_instance.currentScene != null)
			{
				currentScene.Unload();
			}
			_instance.currentScene = newScene;
			currentScene.Load();
		}

		public void PopGUI()
		{
			_guiStack.Pop();
		}

		public void PushGUI(GUI newGui)
		{
			_guiStack.Push(newGui);
		}

	}
}
