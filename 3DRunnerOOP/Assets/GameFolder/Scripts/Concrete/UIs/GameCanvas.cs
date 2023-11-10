using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Managers;
using TMPro;

namespace _3DRunnerOOP.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameOverPanel _gameOverPanel;
        [SerializeField] GamePanel _gamePanel;
        [SerializeField] PauseMenuPanel _pauseMenuPanel;
        [SerializeField] WinGamePanel _winGamePanel;
        private void Awake()
        {
            _gamePanel.gameObject.SetActive(true);
            _pauseMenuPanel.gameObject.SetActive(false);
            _gameOverPanel.gameObject.SetActive(false);
            _winGamePanel.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameStop += HandleOnGameStop;
            GameManager.Instance.OnWinGame += HandleOnWinGame;
            GameManager.Instance.OnGamePause += HandleOnGamePause;
            GameManager.Instance.OnGameContinue += HandleOnGameContinue;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameStop -= HandleOnGameStop;
            GameManager.Instance.OnWinGame -= HandleOnWinGame;
            GameManager.Instance.OnGamePause -= HandleOnGamePause;
            GameManager.Instance.OnGameContinue -= HandleOnGameContinue;
        }

        private void HandleOnGamePause()
        {
            _gamePanel.gameObject.SetActive(false);
            _pauseMenuPanel.gameObject.SetActive(true);
        }

        private void HandleOnGameContinue()
        {
            _gamePanel.gameObject.SetActive(true);
            _pauseMenuPanel.gameObject.SetActive(false);
        }

        private void HandleOnGameStop()
        {
            _gameOverPanel.gameObject.SetActive(true);
            _gamePanel.gameObject.SetActive(false);
        }

        private void HandleOnWinGame()
        {
            _winGamePanel.gameObject.SetActive(true);
            _gamePanel.gameObject.SetActive(false);
        }

    }
}

