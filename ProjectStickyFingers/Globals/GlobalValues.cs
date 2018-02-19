using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;


namespace ProjectStickyFingers.Globals
{
	class GlobalValues
	{
		private static GlobalValues _instance;

		private int _width;
		private int _height;

		public Vector2 BottomMidAnchor { get; private set; }
		public Vector2 TopMidAnchor { get; private set; }
		public Vector2 LeftMidAnchor { get; private set; }
		public Vector2 RightMidAnchor { get; private set; }

		public Vector2 BottomLeftAnchor { get; private set; }
		public Vector2 BottomRightAnchor { get; private set; }
		public Vector2 TopLeftAnchor { get; private set; }
		public Vector2 TopRightAnchor { get; private set; }

		public Vector2 MidAnchor { get; private set; } // might be unnecessary


		public GlobalValues() { }

		public static GlobalValues Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new GlobalValues();
				}
				return _instance;
			}
		}

		public void SetInstance(ContentManager contentManager)
		{
			SetAnchors();
		}

		public void SetAnchors()
		{
			_width = Game1.WINDOW_WIDTH;
			_height = Game1.WINDOW_HEIGHT;

			BottomLeftAnchor = new Vector2(0, _height);
			BottomMidAnchor = new Vector2(_width / 2, _height);
			BottomRightAnchor = new Vector2(_width, _height);

			TopLeftAnchor = new Vector2(0, 0);
			TopMidAnchor = new Vector2(_width / 2, 0);
			TopRightAnchor = new Vector2(_width, 0);

			LeftMidAnchor = new Vector2(0, _height / 2);
			MidAnchor = new Vector2(_width / 2, _height / 2);
			RightMidAnchor = new Vector2(_width, _height / 2);
		}

		public Vector2 AdjustedLocation(Vector2 position, Vector2 textureSize)
		{
			return position -= new Vector2(textureSize.X / 2, textureSize.Y / 2);
		}

	}
}
