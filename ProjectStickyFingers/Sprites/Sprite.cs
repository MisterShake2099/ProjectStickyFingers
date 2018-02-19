using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.Sprites
{
	public class Sprite
	{
		private Rectangle _currentRenderBounds { get; set; }

		protected Texture2D Texture { get; set; }
		protected Vector2 Position { get; set; }
		protected Vector2 Size { get; set; }

		public Rectangle RenderBounds
		{
			get
			{
				return new Rectangle(Position.ToPoint(), Size.ToPoint());
			}
		}


		public Sprite(Texture2D texture, Vector2 position)
			: this(texture, position, new Vector2(texture.Width, texture.Height)) { }

		public Sprite(Texture2D texture, Vector2 position, Vector2 size)
		{
			Texture = texture;
			Position = position;
			Size = size;

			_currentRenderBounds = RenderBounds;
		}

		public virtual void Update(GameTime gameTime)
		{
			//if (IsMoved) { _currentRenderBounds = RenderBounds; }
		}

		public virtual void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(Texture, _currentRenderBounds, Color.White);
		}

	}
}
