using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers
{
	public class ContentHandler
	{
		private static ContentHandler _instance;
		public SpriteFont MenuScreen_Title { get; set; }
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

			//Some Scene
			//SimpleTestHouse = contentManager.Load<Texture2D>("simpleTestHouse");
		}


	}
}
