using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float _timeRemaining = 24.00f;
    public Text _countDown;

    private void Start()
    {
        StartCoroutine(buzzerTime());
    }

    IEnumerator buzzerTime()
    {
        while(_timeRemaining > 0)
        {
            _countDown.text = _timeRemaining.ToString();

            yield return new WaitForSeconds(1.0f);

            _timeRemaining--;
        }

        _countDown.text = _timeRemaining.ToString();

    }

    public void addTime()
    {
        _timeRemaining += 3.0f;
    }


}
