using Microsoft.Xna.Framework.Input;


namespace ProjectStickyFingers
{
	public class InputManager
	{
		private static InputManager _instance;

		public KeyboardState PreviousKeyState { get; set; }
		public KeyboardState CurrentKeyState { get; set; }


		public InputManager(){}


		public static InputManager GetInstance()
		{
			if (_instance == null)
			{
				_instance = new InputManager();
			}
			return _instance;
		}


		public void Update()
		{
			PreviousKeyState = CurrentKeyState;
			CurrentKeyState = Keyboard.GetState();
		}


		public bool KeyPressed(Keys key)
		{
			if(CurrentKeyState.IsKeyDown(key) && PreviousKeyState.IsKeyUp(key))
			{
				return true;
			}
			return false;
		}


		public bool KeyPressed(params Keys[] keys)
		{
			foreach(Keys key in keys)
			{
				if(KeyPressed(key)) { return true; }
			}
			return false;
		}


		public bool KeyReleased(Keys key)
		{
			if (CurrentKeyState.IsKeyUp(key) && PreviousKeyState.IsKeyDown(key))
			{
				return true;
			}
			return false;
		}


		public bool KeyReleased(params Keys[] keys)
		{
			foreach (Keys key in keys)
			{
				if (KeyReleased(key)) { return true; }
			}
			return false;
		}


		public bool KeyDown(Keys key)
		{
			if(CurrentKeyState.IsKeyDown(key))
			{
				return true;
			}
			return false;
		}


		public bool KeyDown(params Keys[] keys)
		{
			foreach(Keys key in keys)
			{
				if (KeyDown(key)) { return true; }
			}
			return false;
		}


	}
}
