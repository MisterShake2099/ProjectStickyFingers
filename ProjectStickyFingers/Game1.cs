using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjectStickyFingers
{
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this)
			{
				PreferredBackBufferWidth = 1280,
				PreferredBackBufferHeight = 720
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
			spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
		}

		protected override void UnloadContent(){}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
			{
				Exit();
			}


			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);


			base.Draw(gameTime);
		}
	}

}
