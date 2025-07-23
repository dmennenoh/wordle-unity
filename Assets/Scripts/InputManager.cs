using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

namespace wordleUnity
{
    public class InputManager : MonoBehaviour
    {
        public delegate void KeyboardAction();
        public static event KeyboardAction OnKeypress;

        private char _lastChar;


        void OnEnable()
        {
            Keyboard.current.onTextInput += GetKeyInput;
        }


        private void OnDisable()
        {
            Keyboard.current.onTextInput -= GetKeyInput;
        }

        public void KeyboardInput(string key)
        {

        }

        private void GetKeyInput(char obj)
        {
            _lastChar = obj;
            if (Input.GetKey(KeyCode.Escape)) return;
            if (Input.GetKey(KeyCode.Return)) _lastChar = char.Parse("\n");
            OnKeypress?.Invoke();
        }


        //Called by GameManager whenever the iistener is invoked
        public char LastChar
        {
            get
            {
                return _lastChar;
            }
        }
    }
}
