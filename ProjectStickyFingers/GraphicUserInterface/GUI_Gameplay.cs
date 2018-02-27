using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using ProjectStickyFingers.Scenes;
using ProjectStickyFingers.Globals;
using ProjectStickyFingers.ContentHandlers;

namespace ProjectStickyFingers.GraphicUserInterface
{
	class GUI_Gameplay : GUI
	{
		private Texture2D _panelTx = ContentHandler.Instance.ColoredTexture(null);


		public GUI_Gameplay()
		{
			Widgets = InitializeWidgets();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);
		}

		public override void HandleWidgetActivated(Widget caller)
		{
			switch (caller.Name)
			{
				case "ButtonMapText":
					
					//SceneManager.Instance.ChangeScene(new Scene_Test());
					break;
				case "Journal":
					break;
			}
		}

		public override Dictionary<string, Widget> InitializeWidgets()
		{
			return new Dictionary<string, Widget>
			{
				// Info panel in upper left.
				{ "PanelInfo", new Widget_Panel("PanelInfo", this, _panelTx, Vector2.Zero, new Vector2(300, 120), null ) },
				{ "PanelInfoTime", new Widget_Panel("PanelInfoTime", this, "Time:", Vector2.Zero, new Vector2(200, 100), new Vector2(10, 10) ) },
				{ "PanelInfoDate", new Widget_Panel("PanelInfoDate", this, "Date:", Vector2.Zero, new Vector2(200, 100), new Vector2(10, 40) ) },
				{ "PanelInfoWeather", new Widget_Panel("PanelInfoWeather", this, "Weather:", Vector2.Zero, new Vector2(200, 100), new Vector2(10, 70) ) },

				// Stats panel in upper right.
				{ "PanelStats", new Widget_Panel("PanelStats", this, _panelTx, GlobalValues.Instance.TopRightAnchor, new Vector2(210, 120), new Vector2(-210, 0) ) },
				{ "PanelStatsPower", new Widget_Panel("PanelStatsPower", this, "X Power", GlobalValues.Instance.TopRightAnchor, new Vector2(200, 100), new Vector2(-190, 10) ) },
				{ "PanelStatsNotoriety", new Widget_Panel("PanelStatsNotoriety", this, "X Notoriety", GlobalValues.Instance.TopRightAnchor, new Vector2(200, 100), new Vector2(-190, 40) ) },
				{ "PanelStatsWealth", new Widget_Panel("PanelStatsWealth", this, "X Wealth", GlobalValues.Instance.TopRightAnchor, new Vector2(200, 100), new Vector2(-190, 70) ) },

				// Panel for items/inventory
				{ "PanelItems", new Widget_Panel("PanelItems", this, _panelTx, GlobalValues.Instance.LeftMidAnchor, new Vector2(210, 250), null ) },
				{ "PanelItemsSep", new Widget_Panel("PanelItemsSep", this, "_____________", GlobalValues.Instance.LeftMidAnchor, new Vector2(200, 100), new Vector2(2, -10) ) },
				{ "PanelItemsHeld", new Widget_Panel("PanelItemsHeld", this, "Held Items", GlobalValues.Instance.LeftMidAnchor, new Vector2(200, 100), new Vector2(22, 10) ) },

				// Panel for Map
				{ "ButtonMap", new Widget_Panel("ButtonMap", this, _panelTx, GlobalValues.Instance.BottomLeftAnchor, new Vector2(62, 30), new Vector2(18, -43) ) },
				{ "ButtonMapText", new Widget_Button("ButtonMapText", this, "MAP", GlobalValues.Instance.BottomLeftAnchor, new Vector2(20, -80), new Vector2(50, 32) ) },

				// Panel for Journal
				{ "ButtonJournal", new Widget_Panel("ButtonJournal", this, _panelTx, GlobalValues.Instance.BottomLeftAnchor, new Vector2(120, 30), new Vector2(100, -43) ) },
				{ "ButtonJournalText", new Widget_Button("ButtonJournalText", this, "Journal", GlobalValues.Instance.BottomLeftAnchor, new Vector2(100, -80), new Vector2(32, 78) ) },

				// Panel for Dialogue
				{ "PanelDialogue", new Widget_Panel("PanelDialogue", this, _panelTx, GlobalValues.Instance.BottomMidAnchor, new Vector2(600, 175), new Vector2(-250, -175) ) },
			};
		}

	}
}
