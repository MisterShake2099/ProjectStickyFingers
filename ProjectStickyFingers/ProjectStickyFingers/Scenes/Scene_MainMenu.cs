using Microsoft.Xna.Framework;
using Nez;


namespace ProjectStickyFingers.Scenes
{
	class Scene_MainMenu : Scene
	{
		private IFont _font = Graphics.instance.bitmapFont;
		private Vector2 _scale = new Vector2( 3, 3 );

		public Scene_MainMenu()
		{
			addRenderer( new DefaultRenderer() );

			// Start Button
			Entity startButton = createEntity( "startButton" );
			startButton.transform.scale = _scale;
			startButton.addComponent( new Text( _font, "Start", Vector2.Zero, Color.Gold ) );

			// Options Button
			Entity optionsButton = createEntity( "optionsButton" );
			optionsButton.transform.scale = _scale;			
			optionsButton.addComponent( new Text( _font, "Options", Vector2.Zero, Color.Gold ) );

			// Exit Button
			Entity exitButton = createEntity( "exitButton" );
			exitButton.transform.scale = _scale;
			exitButton.addComponent( new Text( _font, "Exit", Vector2.Zero, Color.Gold ) );
			   




			/*
			Entity textEntity = createEntity( "text" );
			textEntity.transform.scale = new Vector2( 3, 3 );
			textEntity.addComponent( new Text( Graphics.instance.bitmapFont, "TEXT", Vector2.Zero, Color.White ) );

			Texture2D image = content.Load<Texture2D>( "test/image" );
			Entity entity = createEntity( "image" );
			entity.addComponent( new Sprite( image ) );
			entity.transform.position = new Vector2( 400, 400 );

			TextureAtlas atlas = content.Load<TextureAtlas>( "bin/Windows/test/FirstAtlas" );
			SpriteAnimation animation = atlas.getSpriteAnimation( "coin" );

			Entity entity2 = createEntity( "animation" );
			entity2.addComponent( new Sprite<Animation>( Animation.coin, animation ) );
			entity2.transform.position = new Vector2( 100, 100 );
			entity2.transform.scale = new Vector2( 5, 5 );

			Sprite<Animation> sprite = entity2.getComponent<Sprite<Animation>>();
			sprite.play( Animation.coin );
			*/
		}

	}
}
