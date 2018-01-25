using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers
{
	public class ContentHandler
	{
		private static ContentHandler _instance;
		ContentManager _contentManager;

		//Menu Screen
		public SpriteFont MenuScreen_Title { get; set; }
		public SpriteFont MenuScreen_Selections { get; set; }
		public Texture2D MenuScreen_Selector { get; set; }

		//Game Scene
		public Texture2D Game_GuiFrame { get; set; }
		public Texture2D Game_TavernInside { get; set; }

		//Some Scene
		public Texture2D SimpleTestHouse { get; set; }


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
		}


		public void LoadTextures()
		{
			//Menu Screen
			MenuScreen_Title = _contentManager.Load<SpriteFont>("Fonts/MenuScreen_Title");
			MenuScreen_Selections = _contentManager.Load<SpriteFont>("Fonts/MenuScreen_Selections");
			MenuScreen_Selector = _contentManager.Load<Texture2D>("arrowSilver_right");

			//Game Scene
			Game_GuiFrame = _contentManager.Load<Texture2D>("prototype_UI_frame");
			Game_TavernInside = _contentManager.Load<Texture2D>("tavern_inside");

			//Some Scene
			SimpleTestHouse = _contentManager.Load<Texture2D>("simpleTestHouse");
		}


	}
}
