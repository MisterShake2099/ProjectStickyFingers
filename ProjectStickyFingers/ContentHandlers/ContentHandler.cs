using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers.ContentHandlers
{
	public class ContentHandler
	{
		private static ContentHandler _instance;
		private ContentManager _contentManager;

		private ContentHandler_Dialogue _dialogue;

		private Dictionary<string, SpriteFont> _fonts;
		private Dictionary<string, Texture2D> _textures;
		private Dictionary<string, SoundEffect> _sounds;


		public static ContentHandler Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new ContentHandler();
				}
				return _instance;
			}
		}

		public void SetContentManager(ContentManager contentManager)
		{
			_contentManager = contentManager;
			_dialogue = new ContentHandler_Dialogue(_contentManager);
		}

		public string GetDialogue(string key)
		{
			return _dialogue.GetDialogue(key);
		}

		public SpriteFont GetSpriteFont(string name)
		{
			_fonts.TryGetValue(name, out SpriteFont font);
			return font;
		}

		public Texture2D GetTexture2D(string name)
		{
			_textures.TryGetValue(name, out Texture2D texture);
			return texture;
		}

		public SoundEffect GetSoundEffect(string name)
		{
			_sounds.TryGetValue(name, out SoundEffect sound);
			return sound;
		}

		public void LoadAllContent()
		{
			_dialogue.LoadAllContent();
			_fonts = LoadFonts();
			_textures = LoadTextures();
			_sounds = LoadSounds();

			FinishEmptyTexture();
		}

		private Dictionary<string, SpriteFont> LoadFonts()
		{
			return new Dictionary<string, SpriteFont>
			{
				{ "Title_Romulus", _contentManager.Load<SpriteFont>("Fonts/Title_Romulus") },
				{ "Font_Alagard", _contentManager.Load<SpriteFont>("Fonts/Font_Alagard") },
				{ "Font_Romulus", _contentManager.Load<SpriteFont>("Fonts/Font_Romulus") }
			};
		}

		private Dictionary<string, Texture2D> LoadTextures()
		{
			return new Dictionary<string, Texture2D>
			{
				// GUI - Agnostic
				{ "GUI_sideInfo", _contentManager.Load<Texture2D>("GUI_sideInfo") },

				// Menu Screen
				{ "MenuScreen_Selector", _contentManager.Load<Texture2D>("arrowSilver_right") },
				{ "MenuScreen_StartButton", _contentManager.Load<Texture2D>("Buttons/prototype_startButton") },
				
				// Game Scene
				{ "Game_TavernInside", _contentManager.Load<Texture2D>("testing sprites/tavern_inside") },

				// testing sprites
				{ "EmptyTexture", _contentManager.Load<Texture2D>("testing sprites/EmptyTexture") },
				{ "SimpleTestHouse", _contentManager.Load<Texture2D>("testing sprites/simpleTestHouse") },
				{ "CastleTown", _contentManager.Load<Texture2D>("testing sprites/castleTown") }
			};
		}

		private Dictionary<string, SoundEffect> LoadSounds()
		{
			return new Dictionary<string, SoundEffect>
			{
			
			};
		}

		private void FinishEmptyTexture()
		{
			_textures.TryGetValue("EmptyTexture", out Texture2D temp);
			temp.SetData(new Color[] { new Color(Color.Black, 150) });
		}

	}
}
