using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Managers;
using TMPro;

namespace _3DRunnerOOP.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void RestartButton()
        {
            GameManager.Instance.LoadGame("Game");
            SoundManager.Instance.PlaySoundWithCondition(1);
        }
        public void BackToMenuButton()
        {
            GameManager.Instance.LoadGame("Menu");
            SoundManager.Instance.PlaySoundWithCondition(1);
        }
    }
}

