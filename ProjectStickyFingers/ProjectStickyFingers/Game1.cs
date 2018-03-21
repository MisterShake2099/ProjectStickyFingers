using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using Nez.TextureAtlases;

namespace ProjectStickyFingers
{
	public class Game1 : Core
    {
		public enum Animation
		{
			coin
		}

        public Game1() : base() { }

        protected override void Initialize()
        {
			base.Initialize();

			Scene scene = Scene.createWithDefaultRenderer( Color.CornflowerBlue );


			Texture2D image = scene.content.Load<Texture2D>( "test/image" );
			Entity entity = scene.createEntity( "image" );
			entity.addComponent( new Sprite( image ) );
			entity.transform.position = new Vector2( 400, 400 );


			TextureAtlas atlas = scene.content.Load<TextureAtlas>( "bin/Windows/test/FirstAtlas" );
			SpriteAnimation animation = atlas.getSpriteAnimation( "coin" );


			Entity entity2 = scene.createEntity( "animation" );
			entity2.addComponent( new Sprite<Animation>( Animation.coin, animation ) );
			entity2.transform.position = new Vector2( 100, 100 );


			Sprite<Animation> sprite = entity2.getComponent<Sprite<Animation>>();
			sprite.play( Animation.coin );


			Core.scene = scene;
		}

    }
}
