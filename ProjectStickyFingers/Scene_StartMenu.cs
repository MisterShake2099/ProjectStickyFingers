using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectStickyFingers
{
	class Scene_StartMenu : Scene
	{
		private SpriteFont _title;
		


		public Scene_StartMenu()
		{
			SceneName = "StartMenu";
			_title = contentHandler.MenuScreen_Title;
		}


		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(_title, "The Fence", new Vector2(Game1.width / 2, Game1.height / 2), Color.Black);

			base.Draw(spriteBatch);
		}


	}
}
