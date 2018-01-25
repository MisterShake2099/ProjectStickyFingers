using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace ProjectStickyFingers.States
{
	public abstract class State
	{
		protected enum StateNames
		{
			START_MENU,
			INTRO,
			GAME
		}


		public String StateName { get; set; }


		public abstract void Update(GameTime gameTime);


		public abstract void Draw(SpriteBatch spriteBatch);


	}
}
