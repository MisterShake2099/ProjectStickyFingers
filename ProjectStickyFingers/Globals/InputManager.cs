using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace ProjectStickyFingers.Globals
{
	public class InputManager
	{
		private KeyboardState CurrentKeyState { get; set; }
		private KeyboardState PreviousKeyState { get; set; }

		private MouseState CurrentMouseState { get; set; }
		private MouseState PreviousMouseState { get; set; }

		private Game _game;
		private static InputManager _instance;
		

		public InputManager(){}

		public static InputManager Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new InputManager();
				}
				return _instance;
			}
		}
		public void SetGameInstance(Game game)
		{
			_game = game;
		}

		public void Update()
		{
			PreviousKeyState = CurrentKeyState;
			CurrentKeyState = Keyboard.GetState();

			PreviousMouseState = CurrentMouseState;
			CurrentMouseState = Mouse.GetState();
		}

		public void Quit()
		{
			_game.Exit();
		}

		/* Keyboard */
		public bool AnyKeyPressed()
		{
			return (CurrentKeyState.GetPressedKeys().Length > 0 &&
					PreviousKeyState.GetPressedKeys().Length == 0);
		}

		public bool KeyDown(Keys key)
		{
			return (CurrentKeyState.IsKeyDown(key));
		}
		public bool KeyDown(params Keys[] keys)
		{
			foreach (Keys key in keys)
			{
				return (KeyDown(key));
			}
			return false;
		}

		public bool KeyPressed(Keys key)
		{
			return (CurrentKeyState.IsKeyDown(key) && PreviousKeyState.IsKeyUp(key));
		}
		public bool KeyPressed(params Keys[] keys)
		{
			foreach (Keys key in keys)
			{
				if (KeyPressed(key)) { return true; }
			}
			return false;
		}

		public bool KeyReleased(Keys key)
		{
			return (CurrentKeyState.IsKeyUp(key) && PreviousKeyState.IsKeyDown(key));
		}
		public bool KeyReleased(params Keys[] keys)
		{
			foreach (Keys key in keys)
			{
				return (KeyReleased(key));
			}
			return false;
		}

		/* Mouse */
		public Point MousePosition()
		{
			return CurrentMouseState.Position;
		}
		public bool MouseMoved()
		{
			return (PreviousMouseState.Position != CurrentMouseState.Position);
		}

		public bool MouseLeftDown()
		{
			return (CurrentMouseState.LeftButton == ButtonState.Pressed);
		}
		public bool MouseRightDown()
		{
			return (CurrentMouseState.RightButton == ButtonState.Pressed);
		}

		public bool MouseLeftPressed()
		{
			return (MouseLeftDown() && PreviousMouseState.LeftButton != ButtonState.Pressed);
		}
		public bool MouseRightPressed()
		{
			return (MouseRightDown() && PreviousMouseState.RightButton != ButtonState.Pressed);
		}

		public bool MouseLeftReleased()
		{
			return (!MouseLeftDown() && PreviousMouseState.LeftButton == ButtonState.Pressed);
		}
		public bool MouseRightReleased()
		{
			return (!MouseRightDown() && PreviousMouseState.RightButton == ButtonState.Pressed);
		}

	}
}
