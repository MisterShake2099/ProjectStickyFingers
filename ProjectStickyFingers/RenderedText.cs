using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers
{
	public enum HorizontalAlignment { Left, Center, Right }
	public enum VerticalAlignment { Top, Center, Bottom }

	public class RenderedText
	{
		private SpriteFont _spriteFont;
		private string _text;
		private Color _color;
		private Rectangle _renderBounds;
		private HorizontalAlignment _hAlign;
		private VerticalAlignment _vAlign;
		private Vector2 _textOrigin;

		public RenderedText(SpriteFont spriteFont, string text, Color color, Rectangle renderBounds, HorizontalAlignment hAlign, VerticalAlignment vAlign)
		{
			_spriteFont = spriteFont;
			_text = text;
			_color = color;
			_renderBounds = renderBounds;
			_hAlign = hAlign;
			_vAlign = vAlign;
			_textOrigin = new Vector2(_renderBounds.X, _renderBounds.Y);

			RenderText();
		}

		private void RenderText()
		{
			Vector2 textSize = _spriteFont.MeasureString(_text);

			if (textSize.X > _renderBounds.X)
			{
				WordWrap();
			}

			textSize = _spriteFont.MeasureString(_text);

			switch (_hAlign)
			{
				case HorizontalAlignment.Left:
					_textOrigin.X = _renderBounds.X;
					break;
				case HorizontalAlignment.Center:
					_textOrigin.X += (int)((_renderBounds.Width - textSize.X) / 2);
					break;
				case HorizontalAlignment.Right:
					_textOrigin.X += (int)(_renderBounds.Width - textSize.X);
					break;
			}

			switch (_vAlign)
			{
				case VerticalAlignment.Top:
					_textOrigin.Y = _renderBounds.Y;
					break;
				case VerticalAlignment.Center:
					_textOrigin.Y += (int)((_renderBounds.Height - textSize.Y) / 2);
					break;
				case VerticalAlignment.Bottom:
					_textOrigin.Y += (int)(_renderBounds.Height - textSize.Y);
					break;
			}
		}

		public void WordWrap()
		{
			string finalString = string.Empty;
			string[] words = _text.Split(' ');
			string currentLine = "";
			int maxLineLength = _renderBounds.Width;
			int newLineLength;

			foreach (string word in words)
			{
				newLineLength = (int)_spriteFont.MeasureString(currentLine + word).Length();
				if (newLineLength > maxLineLength)
				{
					finalString += currentLine + "\n";
					currentLine = "";
				}
				currentLine += word + " ";
			}

			_text = finalString + currentLine;
		}

		public static Rectangle FullWindowRectangle() => new Rectangle(0, 0, Game1.WINDOW_WIDTH, Game1.WINDOW_HEIGHT);

		public void Update(GameTime gameTime, string newText)
		{
			_text = newText;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(_spriteFont, _text, _textOrigin, _color);
		}

	}
}
