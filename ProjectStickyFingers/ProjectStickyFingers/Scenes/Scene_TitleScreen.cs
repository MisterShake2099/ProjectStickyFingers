using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;

namespace ProjectStickyFingers.Scenes
{
	public class Scene_TitleScreen : Scene
	{
		public override void initialize()
		{
			base.initialize();

			// create our Scene with the DefaultRenderer and a clear color of CornflowerBlue
			//Scene myScene = Scene.
			//createWithDefaultRenderer( Color.CornflowerBlue );
			setDesignResolution( 1280, 720, Scene.SceneResolutionPolicy.None );
			addRenderer( new DefaultRenderer());

			// load a Texture. Note that the Texture is loaded via the scene.content class. This works just like the standard MonoGame Content class
			// with the big difference being that it is tied to a Scene. When the Scene is unloaded so too is all the content loaded via myScene.content.
			Texture2D texture = content.Load<Texture2D>( "test/simpleTestHouse" );

			// setup our Scene by adding some Entities
			Entity entityOne = createEntity( "entity-one" );
			entityOne.addComponent( new Sprite( texture ) );

			Entity entityTwo = createEntity( "entity-two" );
			entityTwo.addComponent( new Sprite( texture ) );

			// move entityTwo to a new location so it isn't overlapping entityOne
			entityTwo.position = new Vector2( 200, 200 );
		}

	}
}
