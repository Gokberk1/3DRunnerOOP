using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using _3DRunnerOOP.Movements;
using _3DRunnerOOP.Abstract.Inputs;
using _3DRunnerOOP.Inputs;
using UnityEngine.InputSystem;
using _3DRunnerOOP.Managers;

namespace _3DRunnerOOP.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _runningSpeed = 4f;
        [SerializeField] float _moveBoundary = 3.6f;

        [SerializeField] TMP_Text _scoreText;
        [SerializeField] TMP_Text _winGameScoreText;
        [SerializeField] TMP_Text _highScoreText;
        [SerializeField] TMP_Text _winGameHighScoreText;

        [SerializeField] Animator _playerAnim;

        IInputReader _input;
        HorizontalMovement _horizontalMovement;
        Running _running;

        float _horizontal;
        bool _isDead = false;
        bool _isRunning;
        int _score;
        public int Score => _score;
        public float MoveSpeed => _moveSpeed;
        public float MoveBoundary => _moveBoundary;

        private void Awake()
        {
            _horizontalMovement = new HorizontalMovement(this);
            _running = new Running(this);
            _input = new InputReader(GetComponent<PlayerInput>());

            _scoreText.gameObject.SetActive(true);
            _score = 0;

            _isRunning = true;
        }

        private void Update()
        {
            if (_isDead) 
            {
                return;
            } 
            else if (_isRunning)
            {
                _horizontal = _input.Horizontal;
            }
        }

        private void FixedUpdate()
        {
            _horizontalMovement.TickFixed(_horizontal);
            _running.TickFixed(_runningSpeed);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("obstacle"))
            {
                _isDead = true;

                //highScore update
                _scoreText.gameObject.SetActive(false);
                if (_score > PlayerPrefs.GetInt("highScore"))
                {
                    PlayerPrefs.SetInt("highScore", _score);
                }
                _highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
                //

                GameManager.Instance.StopGame();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("coin"))
            {
                //Score update
                _score++;
                _scoreText.text = _score.ToString();
                //
                Destroy(other.gameObject);
                SoundManager.Instance.PlaySound(2);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("finishLine"))
            {
                _runningSpeed = 0;
                _isRunning = false;
                _playerAnim.SetBool("Finish", true);
                _winGameScoreText.text = _score.ToString();
                if (_score > PlayerPrefs.GetInt("highScore"))
                {
                    PlayerPrefs.SetInt("highScore", _score);
                }
                _winGameHighScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
                GameManager.Instance.WinGame();
            }
        }
    }
}

