using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectStickyFingers.Scenes;


namespace ProjectStickyFingers.States
{
	class State_Game : State
	{
		private const string _dialoguePlaceholderText = "You enter the shitty tavern. Looks expectedly empty.\nDon't fuck up.";

		private Scene _datetimeScene;
		private Scene _infoScene;
		private Scene _visualScene;
		private Scene _textScene;

		private SpriteFont _font = ContentHandler.Instance.MenuScreen_Selections;

		private Rectangle _datetimeRect;
		private RenderedText _datetimeRenderer;

		private Rectangle _infoRect;
		private RenderedText _infoRenderer;

		private Rectangle _textRect;
		private RenderedText _textTextRenderer;

		private Rectangle _visualRect;

		private Texture2D _insideTavern;
		private Texture2D _guiFrame;

		private StaticSprite _insideTavernSprite;
		private StaticSprite _guiFrameSprite;

		RenderedText _tempText;


		public State_Game()
		{
			_datetimeRect = new Rectangle(28, 28, 330, 173);
			_datetimeRect.Inflate(-3, 0);
			_datetimeRenderer = new RenderedText(_font, DateTime.Now.Date.ToString() + "\n\nWeather: Cloudy", Color.Gold, _datetimeRect, HorizontalAlignment.Left, VerticalAlignment.Top);

			_infoRect = new Rectangle(28, 192, 320, 501);
			_infoRenderer = new RenderedText(_font, "Inventory | Stats", Color.Gold, _infoRect, HorizontalAlignment.Center, VerticalAlignment.Top);
			_infoRect.Inflate(0, -8);
			_tempText = new RenderedText(_font, "___________", Color.Gold, _infoRect, HorizontalAlignment.Center, VerticalAlignment.Top);

			_textRect = new Rectangle(367, 493, 884, 200);
			_textRect.Inflate(-10, -5);
			_textRect.Offset(5, 2);
			_textTextRenderer = new RenderedText(_font, _dialoguePlaceholderText, Color.Gold, _textRect, HorizontalAlignment.Left, VerticalAlignment.Top);

			_visualRect = new Rectangle(367, 28, 884, 446);

			_datetimeScene = new Scene_MainDatetime(_datetimeRect);
			_infoScene = new Scene_MainInfo(_infoRect);
			_textScene = new Scene_MainText(_textRect);
			_visualScene = new Scene_MainVisual(_visualRect);

			_insideTavern = ContentHandler.Instance.Game_TavernInside;
			_insideTavernSprite = new StaticSprite(_insideTavern, new Vector2(367, 28));

			_guiFrame = ContentHandler.Instance.Game_GuiFrame;
			_guiFrameSprite = new StaticSprite(_guiFrame, Vector2.Zero);
		}


		public override void Update(GameTime gameTime)
		{
			InputManager.Update();
		}


		public override void Draw(SpriteBatch spriteBatch)
		{
			_datetimeRenderer.Draw(spriteBatch);
			_infoRenderer.Draw(spriteBatch);
			_tempText.Draw(spriteBatch);
			_textTextRenderer.Draw(spriteBatch);
			_insideTavernSprite.Draw(spriteBatch);
			_guiFrameSprite.Draw(spriteBatch);
		}


	}
}
