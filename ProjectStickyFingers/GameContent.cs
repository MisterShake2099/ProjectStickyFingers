using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ProjectStickyFingers
{
	class GameContent
	{
		public Texture2D WalkLeft { get; set; }
		public Texture2D WalkRight { get; set; }

		public GameContent(ContentManager contentManager)
		{
			WalkLeft = contentManager.Load<Texture2D>("walk_left");
			WalkRight = contentManager.Load<Texture2D>("walk_right");
		}

	}
}