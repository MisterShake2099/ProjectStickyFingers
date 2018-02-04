﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ProjectStickyFingers.Scenes;
using ProjectStickyFingers.Globals;
using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers
{
	class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public const int WINDOW_WIDTH = 1680;
		public const int WINDOW_HEIGHT = 1050;
		
		public Game1()
		{
			graphics = new GraphicsDeviceManager(this)
			{
				PreferredBackBufferWidth = WINDOW_WIDTH,
				PreferredBackBufferHeight = WINDOW_HEIGHT
			};
			graphics.ApplyChanges();

			Content.RootDirectory = "Content";
		}


		protected override void Initialize()
		{
			var form = (System.Windows.Forms.Form)System.Windows.Forms.Control.FromHandle(this.Window.Handle);
			form.Location = new System.Drawing.Point(50, 50);

			ContentHandler.Instance.SetContentManager(Content);
			InputManager.GetInstance().SetGameInstance(this);
			SceneManager.GetInstance();
			this.IsMouseVisible = true;

			base.Initialize();
		}


		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(GraphicsDevice);

			ContentHandler.Instance.LoadAllContent();
			SceneManager.GetInstance().ChangeScene(new Scene_StartMenu());

			Components.Clear();
		}


		protected override void UnloadContent(){}


		protected override void Update(GameTime gameTime)
		{
			InputManager.GetInstance().Update();

			if (InputManager.GetInstance().KeyPressed(Keys.Escape))
			{
				InputManager.GetInstance().Quit();
			}

			SceneManager.GetInstance().Update(gameTime);
		}


		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.DarkOliveGreen);

			spriteBatch.Begin();
			SceneManager.GetInstance().Draw(spriteBatch);
			spriteBatch.End();
		}


	}
}
