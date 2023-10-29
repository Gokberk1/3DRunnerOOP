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
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _runningSpeed = 4f;
        [SerializeField] float _moveBoundary = 3.6f;
        float _horizontal;

        HorizontalMovement _horizontalMovement;
        Running _running;
        IInputReader _input;

        public float MoveSpeed => _moveSpeed;
        public float MoveBoundary => _moveBoundary;

        private void Awake()
        {
            _horizontalMovement = new HorizontalMovement(this);
            _running = new Running(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            _horizontal = _input.Horizontal;
        }

        private void FixedUpdate()
        {
            _horizontalMovement.TickFixed(_horizontal);
            _running.TickFixed(_runningSpeed);
        }
    }
}

