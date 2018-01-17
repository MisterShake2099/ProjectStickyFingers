using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ProjectStickyFingers
{
	class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		SceneManager sceneManager;
		ContentHandler contentHandler;
		InputManager inputManager;

		public const int WIDTH = 1280;
		public const int HEIGHT = 720;


		public Game1()
		{
			graphics = new GraphicsDeviceManager(this)
			{
				PreferredBackBufferWidth = WIDTH,
				PreferredBackBufferHeight = HEIGHT
			};
			graphics.ApplyChanges();

			Content.RootDirectory = "Content";
		}

		
		protected override void Initialize()
		{
			var form = (System.Windows.Forms.Form)System.Windows.Forms.Control.FromHandle(this.Window.Handle);
			form.Location = new System.Drawing.Point(350, 150);

			base.Initialize();
		}


		protected override void LoadContent()
		{
			sceneManager = new SceneManager();
			contentHandler = ContentHandler.GetInstance();
			spriteBatch = new SpriteBatch(GraphicsDevice);
			contentHandler.LoadTextures(Content);
			sceneManager.LoadScene(new Scene_StartMenu());
			inputManager = new InputManager();
		}


		protected override void UnloadContent(){}


		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
			{
				Exit();
			}

			sceneManager.Update(gameTime);

			base.Update(gameTime);
		}


		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.TransparentBlack);

			spriteBatch.Begin();
			sceneManager.Draw(spriteBatch);
			spriteBatch.End();

			base.Draw(gameTime);
		}


	}
}
