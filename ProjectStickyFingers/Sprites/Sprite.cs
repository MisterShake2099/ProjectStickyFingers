﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.Sprites
{
	public class Sprite
	{
		protected Texture2D StaticTexture { get; set; }
		protected Point Position { get; set; }
		protected Point Size { get; set; }

		public bool IsActive { get; set; }
		public Rectangle RenderBounds
		{
			get
			{
				return new Rectangle(Position, Size);
			}
		}


		public Sprite(Texture2D texture, Point position, bool isActive = true)
			: this(texture, position, new Point(texture.Width, texture.Height), isActive){}

		public Sprite(Texture2D texture, Point position, Point size, bool isActive = true)
		{
			Position = position;
			Size = size;
			StaticTexture = texture;
			IsActive = isActive;
		}

		public virtual void Update(GameTime gameTime)
		{
			// Something that watches for an event indicating
			// that something has been moved or adjusted such
			// that a recalculation is needed.
		}

		public virtual void Draw(SpriteBatch spriteBatch)
		{
			if (IsActive)
			{
				spriteBatch.Draw(StaticTexture, RenderBounds, Color.White);
			}
		}

	}
}
