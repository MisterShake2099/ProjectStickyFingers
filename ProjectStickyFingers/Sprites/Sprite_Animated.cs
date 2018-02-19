using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers.Sprites
{
	class Sprite_Animated : Sprite
	{
		


		public Sprite_Animated(Texture2D texture, Vector2 position)
			: base(texture, position)
		{
		}

		public Sprite_Animated(Texture2D texture, Vector2 position, Vector2 size)
			: base(texture, position, size)
		{
		}
	}
}
