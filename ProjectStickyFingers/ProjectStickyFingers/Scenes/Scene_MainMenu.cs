using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.UI;


namespace ProjectStickyFingers.Scenes
{
	class Scene_MainMenu : Scene
	{
		public UICanvas _canvas;
		private Table _table;

		private IFont _font = Graphics.instance.bitmapFont;
		private Skin _skin;
		private Vector2 _scale = new Vector2( 3, 3 );

		private TextButton startButton;
		private TextButton optionsButton;
		private TextButton exitButton;
		//private Entity startButton;
		//private Entity optionsButton;
		//private Entity exitButton;


		public Scene_MainMenu()
		{
			addRenderer( new DefaultRenderer() );

			SetUp();
		}

		private void SetUp()
		{
			_canvas = createEntity( "GUI" ).addComponent( new UICanvas() );
			_table = _canvas.stage.addElement( new Table() );
			_table.setFillParent( true );
			_skin = new Skin( "skins/skin", content );

			//Label label = new Label( "TEST", _skin );
			//_table.add( label );

			// Start Button
			startButton = new TextButton( "START", _skin, "colored" );
			startButton.setTransform( true );
			//startButton.scaleBy( 5f );
			_table.add( startButton );
			_table.row();
			_table.setTransform( true );
			//_table.scaleBy( 1f );

			// Options Button
			optionsButton = new TextButton( "OPTIONS", _skin, "colored" );
			optionsButton.setTransform( true );
			//optionsButton.scaleBy( 5f );
			_table.add( optionsButton );
			_table.row();
		}

		/*
		private void SetUpEntities()
		{
			// Start Button
			startButton = createEntity( "startButton" );
			startButton.transform.scale = _scale;
			startButton.addComponent( new Text( _font, "Start", Vector2.Zero, Color.Gold ) );

			// Options Button
			optionsButton = createEntity( "optionsButton" );
			optionsButton.transform.scale = _scale;
			optionsButton.addComponent( new Text( _font, "Options", Vector2.Zero, Color.Gold ) );

			// Exit Button
			exitButton = createEntity( "exitButton" );
			exitButton.transform.scale = _scale;
			exitButton.addComponent( new Text( _font, "Exit", Vector2.Zero, Color.Gold ) );
		}
		*/

	}
}


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
