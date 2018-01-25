using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Sprites;


namespace ProjectStickyFingers.Scenes
{
	public abstract class Scene
	{
		protected Rectangle _renderSpace;
		protected List<Sprite> _spriteList;


		public Scene(Rectangle renderSpace)
		{
			_renderSpace = renderSpace;
			_spriteList = new List<Sprite>();
		}


		public abstract void AddVisualElement(Sprite sprite);


		public abstract void Update(GameTime gameTime);


		public abstract void Draw(SpriteBatch spriteBatch);


	}
}
