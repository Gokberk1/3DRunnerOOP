using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Controllers;

namespace _3DRunnerOOP.Movements
{
    public class Running 
    {
        PlayerController _playerController;

        public Running(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void TickFixed(float runSpeed)
        {
            _playerController.transform.Translate(Vector3.forward * runSpeed * Time.fixedDeltaTime);
        }
    }
}

