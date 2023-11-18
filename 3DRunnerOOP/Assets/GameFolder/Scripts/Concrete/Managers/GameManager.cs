using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Abstract.Utilities;
using UnityEngine.SceneManagement;

namespace _3DRunnerOOP.Managers
{
    public class GameManager : SingletonMonoBehaviourObject<GameManager>
    {
        public event System.Action OnGameStop;
        public event System.Action OnWinGame;
        public event System.Action OnGamePause;
        public event System.Action OnGameContinue;

        private void Awake()
        {
            SingletonThisObject(this);
            SoundManager.Instance.PlaySoundWithCondition(0);
        }

        public void StopGame()
        {
            Time.timeScale = 0;

            //if(OnGameStop != null)
            //{
            //    OnGameStop();
            //}

            OnGameStop?.Invoke();
        }

        public void PuseGame()
        {
            Time.timeScale = 0;
            OnGamePause?.Invoke();
        }

        public void ContinueGame()
        {
            Time.timeScale = 1;
            OnGameContinue?.Invoke();
        }

        public void WinGame()
        {
            OnWinGame?.Invoke();
        }

        public void LoadGame(string sceneName)
        {
            StartCoroutine(LoadGameAsync(sceneName));
        }

        private IEnumerator LoadGameAsync(string sceneName)
        {
            Time.timeScale = 1;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

