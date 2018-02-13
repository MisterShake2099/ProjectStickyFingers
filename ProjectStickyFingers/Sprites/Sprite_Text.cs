using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectStickyFingers.Globals;


namespace ProjectStickyFingers.Sprites
{
	public enum HorizontalAlignment { Left, Center, Right }
	public enum VerticalAlignment { Top, Center, Bottom }

	class Sprite_Text : Sprite
	{
		private SpriteFont _spriteFont;
		private string _text;
		private Point _textOrigin;
		private HorizontalAlignment _hAlign;
		private VerticalAlignment _vAlign;


		public Sprite_Text(Point position, Point size, SpriteFont spriteFont, string text, HorizontalAlignment hAlign, VerticalAlignment vAlign)
			: base(null, position, size)
		{
			_spriteFont = spriteFont;
			_text = text;
			_hAlign = hAlign;
			_vAlign = vAlign;

			WordWrap();
			AdjustOrigin();
		}

		public override void Update(GameTime gameTime){}

		public override void Draw(SpriteBatch spriteBatch)
		{
			// Might check for IsActive here, but maybe in the parent instead.
			spriteBatch.DrawString(_spriteFont, _text, Position.ToVector2(), Color.White);
		}

		public void WordWrap()
		{
			string finalString = string.Empty;
			string currentLine = string.Empty;
			string[] words = _text.Split(' ');
			int maxLineLength = Size.X;
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
			Point textSize = _spriteFont.MeasureString(_text).ToPoint();

			switch (_hAlign)
			{
				case HorizontalAlignment.Left:
					_textOrigin.X = Position.X;
					break;
				case HorizontalAlignment.Center:
					_textOrigin.X += (int)((Size.X - textSize.X) / 2);
					break;
				case HorizontalAlignment.Right:
					_textOrigin.X += (int)(Size.X - textSize.X);
					break;
			}

			switch (_vAlign)
			{
				case VerticalAlignment.Top:
					_textOrigin.Y = Position.Y;
					break;
				case VerticalAlignment.Center:
					_textOrigin.Y += (int)((Size.Y - textSize.Y) / 2);
					break;
				case VerticalAlignment.Bottom:
					_textOrigin.Y += (int)(Size.Y - textSize.Y);
					break;
			}
		}

	}
}
