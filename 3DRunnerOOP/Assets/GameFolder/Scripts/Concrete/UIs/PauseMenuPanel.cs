using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Managers;

namespace _3DRunnerOOP.UIs
{
    public class PauseMenuPanel : MonoBehaviour
    {
        public void ContinueGame()
        {
            GameManager.Instance.ContinueGame();
            SoundManager.Instance.PlaySoundWithCondition(1);
        }

        public void RestartGame()
        {
            GameManager.Instance.LoadGame("Game");
            SoundManager.Instance.PlaySoundWithCondition(1);
        }
    }

}
