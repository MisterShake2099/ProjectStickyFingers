using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStickyFingers
{
	class TestSprite
	{
		private SpriteBatch spriteBatch;
		private GameContent gameContent;


		public TestSprite(SpriteBatch spriteBatch, GameContent gameContent)
		{
			this.spriteBatch = spriteBatch;
			this.gameContent = gameContent;
		}

		public void Draw()
		{
			spriteBatch.Draw(gameContent.WalkLeft0, new Rectangle(100, 100, 100, 100), Color.White);
		}

	}
}
