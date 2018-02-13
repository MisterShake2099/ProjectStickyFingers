using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.Scenes
{
	abstract class Scene
	{
		protected Rectangle _drawArea { get; set; }

		public abstract void Load();
		public abstract void Update(GameTime gameTime);
		public abstract void Draw(SpriteBatch spriteBatch);

		public virtual void Unload()
		{
			SceneManager.GetInstance().PopGUI();
		}

	}
}
