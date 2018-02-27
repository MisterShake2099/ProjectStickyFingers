

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.Entities
{
	enum X { }


	abstract class Entity
	{

		public abstract void Execute();

		public abstract void Update(GameTime gameTime);

		public abstract void Draw(SpriteBatch spriteBatch);
	}
}
