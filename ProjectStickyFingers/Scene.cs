using Microsoft.Xna.Framework.Graphics;
using System;


namespace ProjectStickyFingers
{
	abstract class Scene
	{
		public String SceneName { get; set; }
		protected ContentHandler contentHandler = ContentHandler.GetInstance();

		public Scene(){}

		public virtual void Draw(SpriteBatch spriteBatch){}

	}

}
