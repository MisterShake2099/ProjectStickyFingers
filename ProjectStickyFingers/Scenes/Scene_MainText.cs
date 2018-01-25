using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectStickyFingers.Sprites;


namespace ProjectStickyFingers.Scenes
{
	class Scene_MainText : Scene
	{
		public Scene_MainText(Rectangle renderSpace) : base(renderSpace)
		{
	
		}


		public override void AddVisualElement(Sprite sprite)
		{
			_spriteList.Add(sprite);
		}


		public override void Update(GameTime gameTime)
		{
			foreach (Sprite sprite in _spriteList)
			{
				sprite.Update(gameTime);
			}
		}


		public override void Draw(SpriteBatch spriteBatch)
		{
			foreach (Sprite sprite in _spriteList)
			{
				sprite.Draw(spriteBatch);
			}
		}


	}
}
