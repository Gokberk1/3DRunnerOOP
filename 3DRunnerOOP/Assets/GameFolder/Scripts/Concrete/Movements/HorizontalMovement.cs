using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Controllers;

namespace _3DRunnerOOP.Movements
{
    public class HorizontalMovement 
    {
        PlayerController _playerController;
        float _moveSpeed;
        float _moveBoundary;

        public HorizontalMovement(PlayerController playerController)
        {
            _playerController = playerController;
            _moveSpeed = _playerController.MoveSpeed;
            _moveBoundary = _playerController.MoveBoundary;
        }

        public void TickFixed(float horizontal)
        {
            if(horizontal == 0)
            {
                return;
            }
            else
            {
                _playerController.transform.Translate(Vector3.right * horizontal * _moveSpeed * Time.deltaTime);
            }
            float xBoundary = Mathf.Clamp(_playerController.transform.position.x, -_moveBoundary, _moveBoundary);

            _playerController.transform.position = new Vector3(xBoundary, _playerController.transform.position.y, _playerController.transform.position.z);
        }
    }
}

