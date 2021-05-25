using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public float _timeRemaining = 24.00f;
    public Text _countDown;
    public Text _TimeUp;
    public Text _restartText;
    public Text _youWon;
    private GameManager _gameManager;
    private bool _timeOver = false;
    private rimScore _Victory;


    private void Start()
    {
        StartCoroutine(buzzerTime());
        _gameManager = GameObject.Find("Game_Manager").GetComponent<GameManager>();
        _Victory = GameObject.Find("Rim_Goal").GetComponent<rimScore>();

        if (_gameManager == null)
        {
            Debug.LogError("GameMamanger is NULL");
        }

        if (_Victory == null)
        {
            Debug.LogError("Rim is NULL");
        }
    }

    private void Update()
    {
        if (_timeRemaining == 0f)
        {
            _timeOver = true;
        }

        TimeUp();
        GameWon();
    }

    IEnumerator buzzerTime()
    {

        while (_timeRemaining > 0)
        {
            _countDown.text = _timeRemaining.ToString();

            yield return new WaitForSeconds(1.0f);

            _timeRemaining--;
        }

        _countDown.text = _timeRemaining.ToString();

    }

    void GameOverSequence()
    {
        _gameManager.GameOver();            // Game Over LOL
        _TimeUp.gameObject.SetActive(true);
        _restartText.gameObject.SetActive(true);
    }

    public void addTime()
    {
        _timeRemaining += 3.0f;
    }

    void TimeUp()
    {
        if (_timeOver == true)
        {
            GameOverSequence();
        }
    }

    void GameWon()
    {
        if (_Victory._gameWon == true)
        {
            _youWon.gameObject.SetActive(true);
            StopAllCoroutines();
        }
    }
}
