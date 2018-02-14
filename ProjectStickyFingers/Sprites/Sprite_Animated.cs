using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers.Sprites
{
	class Sprite_Animated : Sprite
	{
		


		public Sprite_Animated(Texture2D texture, Vector2 position, bool isActive = true)
			: base(texture, position, isActive)
		{
		}

		public Sprite_Animated(Texture2D texture, Vector2 position, Vector2 size, bool isActive = true)
			: base(texture, position, size, isActive)
		{
		}
	}
}
