using Microsoft.Xna.Framework.Input;


namespace ProjectStickyFingers
{
	public class InputManager
	{
		private static InputManager _instance;

		public static KeyboardState PreviousKeyState { get; set; }
		public static KeyboardState CurrentKeyState { get; set; }


		public InputManager(){}

		public static InputManager GetInstance()
		{
			if (_instance == null)
			{
				_instance = new InputManager();
			}
			return _instance;
		}


		public static void Update()
		{
			PreviousKeyState = CurrentKeyState;
			CurrentKeyState = Keyboard.GetState();
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
			if (CurrentKeyState.IsKeyUp(key) && PreviousKeyState.IsKeyDown(key))
			{
				return true;
			}
			return false;
		}


		public static bool KeyReleased(params Keys[] keys)
		{
			foreach (Keys key in keys)
			{
				if (KeyReleased(key)) { return true; }
			}
			return false;
		}


		public static bool KeyDown(Keys key)
		{
			if (CurrentKeyState.IsKeyDown(key))
			{
				return true;
			}
			return false;
		}


		public static bool KeyDown(params Keys[] keys)
		{
			foreach (Keys key in keys)
			{
				if (KeyDown(key)) { return true; }
			}
			return false;
		}


	}
}
