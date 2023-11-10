using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Managers;
using _3DRunnerOOP.Controllers;
using TMPro;

namespace _3DRunnerOOP.UIs
{
    public class GamePanel: MonoBehaviour
    {
       public void PauseGame()
        {
            GameManager.Instance.PuseGame();
            SoundManager.Instance.PlaySoundWithCondition(1);
        }
    }
}

