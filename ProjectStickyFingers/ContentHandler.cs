using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers
{
	public class ContentHandler
	{
		private static ContentHandler _instance;

		//Menu Screen
		public SpriteFont MenuScreen_Title { get; set; }
		public SpriteFont MenuScreen_Selections { get; set; }
		public Texture2D MenuScreen_Selector { get; set; }

		//Some Scene
		public Texture2D SimpleTestHouse { get; set; }


		public ContentHandler(){}

		
		public static ContentHandler GetInstance()
		{
			if (_instance == null)
			{
				_instance = new ContentHandler();
			}

			return _instance;
		}


		public void LoadTextures(ContentManager contentManager)
		{
			//Menu Screen
			MenuScreen_Title = contentManager.Load<SpriteFont>("Fonts/MenuScreen_Title");
			MenuScreen_Selections = contentManager.Load<SpriteFont>("Fonts/MenuScreen_Selections");
			MenuScreen_Selector = contentManager.Load<Texture2D>("arrowSilver_right");

			//Some Scene
			SimpleTestHouse = contentManager.Load<Texture2D>("simpleTestHouse");
		}


	}
}
