﻿using Microsoft.Xna.Framework.Graphics;
using Nez;
using ProjectStickyFingers.Scenes;

namespace ProjectStickyFingers
{
	public enum Animation
	{
		coin
	}

	public class Game1 : Core
    {
		Scene.SceneResolutionPolicy policy;

        public Game1() : base()
		{
			policy = Scene.SceneResolutionPolicy.ShowAllPixelPerfect;
			defaultSamplerState = SamplerState.PointClamp;

			/// Do this once at launch and any new Scene created will adopt the same settings
			Scene.setDefaultDesignResolution( 1280, 720, policy );

			Window.AllowUserResizing = true;
		}

        protected override void Initialize()
        {
			base.Initialize();

			scene = new Scene_MainMenu();
		}

    }
}
