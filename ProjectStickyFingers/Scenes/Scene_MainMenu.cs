using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;
using ProjectStickyFingers.GraphicUserInterface;

using GeonBit.UI;
using GeonBit.UI.Entities;


namespace ProjectStickyFingers.Scenes
{
	class Scene_MainMenu : Scene
	{
		private const string TITLE_STRING = "Project: Sticky Fingers";

		private Sprite_Text _gameTitle;
		private SpriteFont _title;
		private Vector2 _titleDimensions;


		public Scene_MainMenu()
		{
			/*
			_drawArea = new Rectangle(0, 0, Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT);

			_title = ContentHandler.Instance.GetSpriteFont("Title_Romulus");

			_titleDimensions = _title.MeasureString(TITLE_STRING);

			_gameTitle = new Sprite_Text(new Vector2((Game1.WINDOW_WIDTH / 2) - (_titleDimensions.X / 2), Game1.WINDOW_HEIGHT / 3),
										 new Vector2(1000, 100), _title, TITLE_STRING, HorizontalAlignment.Center, VerticalAlignment.Center, Color.Gold);
			*/
		}

		public override void Update(GameTime gameTime) { }

		public override void Draw(SpriteBatch spriteBatch)
		{
			/*_gameTitle.Draw(spriteBatch);*/
		}

		public override void Load()
		{
			SceneManager.Instance.PushGUI(new GUI_MainMenu());
		}

		public override void Unload()
		{
			base.Unload();
		}

	}
}
