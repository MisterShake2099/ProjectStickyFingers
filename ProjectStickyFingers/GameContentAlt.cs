/*
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
	class GameContentAlt
	{
		private static GameContentAlt instance;
		ContentManager ContentManager;

		public Dictionary<String, Texture2D> Textures;
		public Dictionary<String, SoundEffect> Sounds;
		public Dictionary<String, SpriteFont> Fonts;


		private GameContentAlt()
		{
			Textures = new Dictionary<String, Texture2D>();
			Sounds = new Dictionary<String, SoundEffect>();
			Fonts = new Dictionary<String, SpriteFont>();
		}

		public static GameContentAlt GetInstance()
		{
			if (instance == null)
			{
				instance = new GameContentAlt();
			}
			return instance;
		}

		public void LoadTextures(ContentManager contentManager)
		{
			ContentManager = contentManager;
			AddTexture("TestSprite");
		}

		public void AddTexture(String file, String name = "")
		{
			Texture2D texture = ContentManager.Load<Texture2D>(file);

			if (name == "")
			{
				Textures.Add(file, texture);
			}
			else
			{
				Textures.Add(name, texture);
			}
		}

		public void AddSound(String file, String name = "")
		{
			SoundEffect sound = ContentManager.Load<SoundEffect>(file);

			if (name == "")
			{
				Sounds.Add(file, sound);
			}
			else
			{
				Sounds.Add(name, sound);
			}
		}

		public void AddSpriteFont(String file, String name = "")
		{
			SpriteFont font = ContentManager.Load<SpriteFont>(file);

			if (name == "")
			{
				Fonts.Add(file, font);
			}
			else
			{
				Fonts.Add(name, font);
			}
		}

	}
}
*/