using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectStickyFingers.Sprites;

namespace ProjectStickyFingers.Scenes
{
	public abstract class Scene
	{
		protected Rectangle _renderSpace;


		public Scene(Rectangle renderSpace)
		{
			_renderSpace = renderSpace;
		}


		public abstract void AddVisualElement(Sprite sprite);


		public abstract void Update(GameTime gameTime);


		public abstract void Draw(SpriteBatch spriteBatch);


	}
}
