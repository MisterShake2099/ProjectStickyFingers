using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjectStickyFingers
{
	class Scene_StartMenu : Scene
	{
		private const string TITLE_STRING = "The Fence";
		private const string START = "Start";
		private const string OPTIONS = "Options";
		private const string EXIT = "Exit";
		private SpriteFont _title;
		private SpriteFont _selections;
		private Texture2D _selector;
		private Vector2 _titleDimensions;
		private Vector2 _startDimensions;
		private Vector2 _optionsDimensions;
		private Vector2 _exitDimensions;
		private Vector2 _selectorPosition;

		private InputManager inputManager;


		public Scene_StartMenu()
		{
			SceneName = "StartMenu";

			_title = contentHandler.MenuScreen_Title;
			_selections = contentHandler.MenuScreen_Selections;
			_selector = contentHandler.MenuScreen_Selector;

			_titleDimensions = _title.MeasureString(TITLE_STRING);
			_startDimensions = _selections.MeasureString(START);
			_optionsDimensions = _selections.MeasureString(OPTIONS);
			_exitDimensions = _selections.MeasureString(EXIT);

			_selectorPosition = new Vector2(500, 365);

			inputManager = new InputManager();
		}


		public override void Update(GameTime gameTime)
		{
			inputManager.Update();
			if (inputManager.KeyPressed(Keys.S))
			{
				_selectorPosition.Y += 45;
			}

			if (inputManager.KeyPressed(Keys.W))
			{
				_selectorPosition.Y -= 45;
			}
		}


		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(_title, TITLE_STRING, new Vector2((Game1.WIDTH / 2) - (_titleDimensions.X / 2), Game1.HEIGHT / 3), Color.Gold);
			spriteBatch.DrawString(_selections, START, new Vector2((Game1.WIDTH / 2) - (_startDimensions.X / 2), Game1.HEIGHT / 2), Color.Gold);
			spriteBatch.DrawString(_selections, OPTIONS, new Vector2((Game1.WIDTH / 2) - (_optionsDimensions.X / 2), Game1.HEIGHT / 2 + 50), Color.Gold);
			spriteBatch.DrawString(_selections, EXIT, new Vector2((Game1.WIDTH / 2) - (_exitDimensions.X / 2), Game1.HEIGHT / 2 + 100), Color.Gold);

			spriteBatch.Draw(_selector, _selectorPosition, Color.Gold);

			base.Draw(spriteBatch);
		}


	}
}
