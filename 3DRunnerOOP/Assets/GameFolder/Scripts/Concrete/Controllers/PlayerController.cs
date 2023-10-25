using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Movements;
using _3DRunnerOOP.Abstract.Inputs;
using _3DRunnerOOP.Inputs;
using UnityEngine.InputSystem;

namespace _3DRunnerOOP.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _horizontalDirection = 0f;
        [SerializeField] float _moveSpeed = 10f;
        float _horizontal;
        HorizontalMovement _horizontalMovement;
        IInputReader _input;

        private void Awake()
        {
            _horizontalMovement = new HorizontalMovement(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            _horizontal = _input.Horizontal;
        }

        private void FixedUpdate()
        {
            _horizontalMovement.TickFixed(_horizontal, _moveSpeed);
        }
    }
}

