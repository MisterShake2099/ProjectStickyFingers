using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ProjectStickyFingers.States;
using ProjectStickyFingers.ContentHandlers;
using ProjectStickyFingers.Globals;


namespace ProjectStickyFingers
{
	class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public const int WINDOW_WIDTH = 1280;
		public const int WINDOW_HEIGHT = 720;
		
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
			form.Location = new System.Drawing.Point(350, 150);

			ContentHandler.Instance.SetContentManager(Content);
			InputManager.SetGameInstance(this);

			base.Initialize();
		}


		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(GraphicsDevice);

			ContentHandler.Instance.LoadAllContent();
			StateManager.ChangeState(new State_StartMenu());

			Components.Clear();
		}


		protected override void UnloadContent(){}


		protected override void Update(GameTime gameTime)
		{
			//if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
			if (InputManager.KeyPressed(Keys.Escape))
			{
				//Exit();
				InputManager.Quit();
			}

			StateManager.Update(gameTime);
		}


		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.DarkOliveGreen);

			spriteBatch.Begin();
			StateManager.Draw(spriteBatch);
			spriteBatch.End();
		}


	}
}
