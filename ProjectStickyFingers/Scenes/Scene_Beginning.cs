using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Globals;
using ProjectStickyFingers.Sprites;
using ProjectStickyFingers.ContentHandlers;


namespace ProjectStickyFingers.Scenes
{
	class Scene_Beginning : Scene
	{
		private SpriteFont _font = ContentHandler.Instance.GetSpriteFont("Font_Romulus");

		private Texture2D _guiFrame;
		private StaticSprite _guiFrameSprite;
		private Texture2D _insideTavern;
		private StaticSprite _insideTavernSprite;


		public Scene_Beginning()
		{
			_drawArea = new Rectangle(0, 0, Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT);

			_guiFrame = ContentHandler.Instance.GetTexture2D("Game_GuiFrame");
			_guiFrameSprite = new StaticSprite(_guiFrame, _drawArea.Center.ToVector2() - new Vector2(_guiFrame.Width / 2, _guiFrame.Height / 2));

			_insideTavern = ContentHandler.Instance.GetTexture2D("Game_TavernInside");
			_insideTavernSprite = new StaticSprite(_insideTavern, new Vector2((_drawArea.Center.X) - (_insideTavern.Width / 2),
																			  (_drawArea.Center.Y) - (_insideTavern.Height / 2)));
		}

		public override void Update(GameTime gameTime)
		{

		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(_insideTavern, new Rectangle(_guiFrameSprite._position.ToPoint(), _guiFrameSprite._texture.Bounds.Size), Color.White);
			_guiFrameSprite.Draw(spriteBatch);
		}

		public override void Load()
		{

		}

		public override void Unload()
		{

		}
	}
}
