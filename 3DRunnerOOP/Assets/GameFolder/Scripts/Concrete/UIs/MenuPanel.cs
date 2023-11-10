using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Managers;


namespace _3DRunnerOOP.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartButton()
        {
            GameManager.Instance.LoadGame("Game");
            SoundManager.Instance.PlaySoundWithCondition(1);
        }
        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        } 
    }
}

