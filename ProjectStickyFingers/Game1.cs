using Microsoft.Xna.Framework;
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

		// Using 640x360 (16:9) as a base resolution allows
		// for scalling to 720p and 1080p without quality
		// loss for pixel sprites.
		public const int WINDOW_WIDTH = 640 * 2;
		public const int WINDOW_HEIGHT = 360 * 2;

		
		public Game1()
		{
			graphics = new GraphicsDeviceManager(this)
			{
				PreferredBackBufferWidth = WINDOW_WIDTH,
				PreferredBackBufferHeight = WINDOW_HEIGHT
			};
			graphics.IsFullScreen = false;
			graphics.ApplyChanges();

			Content.RootDirectory = "Content";
		}

		protected override void Initialize()
		{
			var form = (System.Windows.Forms.Form)System.Windows.Forms.Control.FromHandle(Window.Handle);
			form.Location = new System.Drawing.Point(200, 200);
			//form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

			ContentHandler.Instance.SetContentManager(Content);
			InputManager.Instance.SetGameInstance(this);
			GlobalValues.Instance.SetInstance(Content);
			SceneManager.Instance.SetInstance();
			IsMouseVisible = true;

			base.Initialize();
		}

		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(GraphicsDevice);

			ContentHandler.Instance.LoadAllContent();
			SceneManager.Instance.ChangeScene(new Scene_StartMenu());

			Components.Clear();
		}

		protected override void UnloadContent(){}

		protected override void Update(GameTime gameTime)
		{
			InputManager.Instance.Update();

			if (InputManager.Instance.KeyPressed(Keys.Escape))
			{
				InputManager.Instance.Quit();
			}

			SceneManager.Instance.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.DarkOliveGreen);

			spriteBatch.Begin(/*SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise*/);
			SceneManager.Instance.Draw(spriteBatch);
			spriteBatch.End();
		}

	}
}
