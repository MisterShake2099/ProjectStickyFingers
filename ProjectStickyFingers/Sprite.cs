using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStickyFingers
{
	// the Sprite class more accurately could be named SpriteSheet
	class Sprite
	{
		Texture2D texture;


		public Sprite(Texture2D texture)
		{
			this.texture = texture;
		}

		public void Update()
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, new Rectangle(100, 100, 100, 100), Color.White);
		}

	}
}
