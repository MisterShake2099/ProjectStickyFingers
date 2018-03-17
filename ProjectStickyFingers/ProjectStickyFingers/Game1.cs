using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using ProjectStickyFingers.Scenes;


namespace ProjectStickyFingers
{
	public class Game1 : Core
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        public Game1()
        {
            //graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
			Window.AllowUserResizing = true;
			defaultSamplerState = SamplerState.PointClamp;
			// set the scene so Nez can take over
			scene = new Scene_TitleScreen();
		}

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent() { }

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
            base.Draw(gameTime);
        }

    }
}
