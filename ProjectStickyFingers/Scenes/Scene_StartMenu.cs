﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;
using ProjectStickyFingers.GraphicUserInterface;


namespace ProjectStickyFingers.Scenes
{
	class Scene_StartMenu : Scene
	{
		private const string TITLE_STRING = "Project: Sticky Fingers";

		private SpriteFont _title;
		private Vector2 _titleDimensions;
		private Sprite_Text _gameTitle;
		
		
		public Scene_StartMenu()
		{
			_drawArea = new Rectangle(0, 0, Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT);

			_title = ContentHandler.Instance.GetSpriteFont("Title_Romulus");

			_titleDimensions = _title.MeasureString(TITLE_STRING);

			_gameTitle = new Sprite_Text(new Vector2((Game1.WINDOW_WIDTH / 2) - (_titleDimensions.X / 2), Game1.WINDOW_HEIGHT / 3),
										 new Vector2(1000, 100), _title, TITLE_STRING, HorizontalAlignment.Center, VerticalAlignment.Center, Color.Gold);
		}

		public override void Update(GameTime gameTime){}

		public override void Draw(SpriteBatch spriteBatch)
		{
			_gameTitle.Draw(spriteBatch);
		}

		public override void Load()
		{
			SceneManager.GetInstance().PushGUI(new GUI_MainMenu());
		}

		public override void Unload()
		{
			base.Unload();
		}

	}
}
