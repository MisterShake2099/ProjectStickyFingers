using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.Sprites
{
	class TextSprite : Sprite
	{
		private SpriteFont _spriteFont;
		private string _text;
		private Rectangle _renderArea;
		private RenderedText _renderedText;
		private Vector2 _textOrigin;


		public TextSprite(SpriteFont spriteFont, string text, Color color, Rectangle renderArea, HorizontalAlignment hAlign, VerticalAlignment vAlign)
		{
			_spriteFont = spriteFont;
			_text = text;
			_color = color;
			_renderArea = renderArea;

			_renderedText = new RenderedText(spriteFont, text, color, renderArea, hAlign, vAlign);
			_textOrigin = _renderedText.RenderText();
			_text = _renderedText._text;
		}


		public override void Update(GameTime gameTime){}


		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(_spriteFont, _text, _textOrigin, _color);
		}


	}
}
