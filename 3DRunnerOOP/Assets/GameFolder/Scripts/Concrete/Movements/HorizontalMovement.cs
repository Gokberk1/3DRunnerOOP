using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Controllers;

namespace _3DRunnerOOP.Movements
{
    public class HorizontalMovement 
    {
        PlayerController _playerController;

        public HorizontalMovement(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void TickFixed(float horizontal, float moveSpeed)
        {
            if(horizontal == 0)
            {
                return;
            }
            else
            {
                _playerController.transform.Translate(Vector3.right * horizontal * moveSpeed * Time.deltaTime);
            }
        }
    }
}

