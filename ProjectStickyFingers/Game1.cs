using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ProjectStickyFingers
{
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		SceneManager sceneManager;
		ContentHandler contentHandler;

		public static int width = 1280;
		public static int height = 720;


		public Game1()
		{
			graphics = new GraphicsDeviceManager(this)
			{
				PreferredBackBufferWidth = width,
				PreferredBackBufferHeight = height
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
		}


		protected override void UnloadContent(){}


		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
			{
				Exit();
			}

			sceneManager.Update();

			base.Update(gameTime);
		}


		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			spriteBatch.Begin();
			sceneManager.Draw(spriteBatch);
			spriteBatch.End();

			base.Draw(gameTime);
		}


	}
}
