using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectStickyFingers
{
	class SpriteAnimation
	{
		// Need to parse a JSON-spritesheet pair
		//TextReader reader;
		//JsonTextReader jsonReader;
		public int CurrentFrame { get; set; }
		public int FrameCount { get; set; }
		public int FrameHeight { get { return Texture.Height; } }
		public int FrameWidth { get; set; }
		public float FrameSpeed { get; set; }
		public bool IsLooping { get; set; }
		public Texture2D Texture { get; set; }


		public SpriteAnimation(Texture2D texture, int frameCount)
		{
			Texture = texture;
			FrameCount = frameCount;
			IsLooping = true;
			FrameSpeed = 0.2f;
		}

		/*
		public void ParseJson()
		{
			jsonReader = new JsonTextReader(reader);
		}
		*/

	}
}
