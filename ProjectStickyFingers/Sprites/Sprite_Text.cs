using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.Sprites
{
	public enum HorizontalAlignment { Left, Center, Right }
	public enum VerticalAlignment { Top, Center, Bottom }

	class Sprite_Text : Sprite
	{
		private SpriteFont _spriteFont;
		private string _text;
		private Vector2 _textOrigin = Vector2.Zero;
		private HorizontalAlignment _hAlign;
		private VerticalAlignment _vAlign;
		private Color _color;


		public Sprite_Text(Vector2 position, Vector2 size, SpriteFont spriteFont, string text, HorizontalAlignment hAlign, VerticalAlignment vAlign, Color? color = null)
			: base(null, position, size)
		{
			_spriteFont = spriteFont;
			_text = text;
			_hAlign = hAlign;
			_vAlign = vAlign;
			_color = color ?? Color.White;

			WordWrap();
			AdjustOrigin();
		}

		public override void Update(GameTime gameTime) { }

		public override void Draw(SpriteBatch spriteBatch)
		{
			//spriteBatch.DrawString(_spriteFont, _text, Position, _color);
			spriteBatch.DrawString(_spriteFont, _text, Position, _color);
		}

		public void WordWrap()
		{
			string finalString = string.Empty;
			string currentLine = string.Empty;
			string[] words = _text.Split(' ');
			int maxLineLength = (int)Size.X;
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

		/* Adjusts the origin of the text's Rectangle
		 * based on alignment parameters and WordWrap(). */
		public void AdjustOrigin()
		{
			Vector2 length = _spriteFont.MeasureString(_text);

			switch (_hAlign)
			{
				case HorizontalAlignment.Left:
					_textOrigin.X = Position.X;
					break;
				case HorizontalAlignment.Center:
					_textOrigin.X += ((Size.X - length.X) / 2);
					break;
				case HorizontalAlignment.Right:
					_textOrigin.X += (Size.X - length.X);
					break;
			}

			switch (_vAlign)
			{
				case VerticalAlignment.Top:
					_textOrigin.Y = Position.Y;
					break;
				case VerticalAlignment.Center:
					_textOrigin.Y += ((Size.Y - length.Y) / 2);
					break;
				case VerticalAlignment.Bottom:
					_textOrigin.Y += (Size.Y - length.Y);
					break;
			}
		}

	}
}
