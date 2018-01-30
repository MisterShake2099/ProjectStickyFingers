using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ProjectStickyFingers.Globals
{
	public class InputManager
	{
		private static KeyboardState CurrentKeyState { get; set; }
		private static KeyboardState PreviousKeyState { get; set; }

		private static Game _game;
		private static InputManager _instance;
		

		public InputManager(){}

		public static InputManager GetInstance()
		{
			if (_instance == null)
			{
				_instance = new InputManager();
			}
			return _instance;
		}
		public static void SetGameInstance(Game game)
		{
			_game = game;
		}

		public static void Update()
		{
			PreviousKeyState = CurrentKeyState;
			CurrentKeyState = Keyboard.GetState();
		}

		public static bool AnyKeyPressed()
		{
			return (CurrentKeyState.GetPressedKeys().Length > 0 &&
					PreviousKeyState.GetPressedKeys().Length == 0);
		}


		public static bool KeyDown(Keys key)
		{
			return (CurrentKeyState.IsKeyDown(key));
		}
		public static bool KeyDown(params Keys[] keys)
		{
			foreach (Keys key in keys)
			{
				return (KeyDown(key));
			}
			return false;
		}

		public static bool KeyPressed(Keys key)
		{
			if (CurrentKeyState.IsKeyDown(key) && PreviousKeyState.IsKeyUp(key))
			{
				return true;
			}
			return false;
		}
		public static bool KeyPressed(params Keys[] keys)
		{
			foreach (Keys key in keys)
			{
				if (KeyPressed(key)) { return true; }
			}
			return false;
		}

		public static bool KeyReleased(Keys key)
		{
			return (CurrentKeyState.IsKeyUp(key) && PreviousKeyState.IsKeyDown(key));
		}
		public static bool KeyReleased(params Keys[] keys)
		{
			foreach (Keys key in keys)
			{
				return (KeyReleased(key));
			}
			return false;
		}

		public static void Quit()
		{
			_game.Exit();
		}

	}
}
