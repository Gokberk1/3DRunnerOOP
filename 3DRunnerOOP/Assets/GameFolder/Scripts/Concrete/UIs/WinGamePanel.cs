using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Managers;

namespace _3DRunnerOOP.UIs
{
    public class WinGamePanel : MonoBehaviour
    {
        public void RestartGame()
        {
            GameManager.Instance.LoadGame("Game");
            SoundManager.Instance.PlaySoundWithCondition(1);
        }
        public void BackToMenu()
        {
            GameManager.Instance.LoadGame("Menu");
            SoundManager.Instance.PlaySoundWithCondition(1);
        }
    }
}

