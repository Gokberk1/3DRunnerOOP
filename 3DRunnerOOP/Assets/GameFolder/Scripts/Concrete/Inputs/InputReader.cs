using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using _3DRunnerOOP.Abstract.Inputs;

namespace _3DRunnerOOP.Inputs
{
    public class InputReader :IInputReader
    {
        PlayerInput _playerInput;

        public float Horizontal { get; private set; }

        public InputReader(PlayerInput playerInput)
        {
            _playerInput = playerInput;
            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
        }

        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();
        }
    }
}

