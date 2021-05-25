using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rimScore : MonoBehaviour
{
    [SerializeField]
    private GameObject _fireWorks;
    public bool _gameWon = false;
    private AudioSource _Winner;

    // Update is called once per frame
    private void Start()
    {
        _Winner = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _fireWorks.SetActive(true);
            _Winner.Play();
            _gameWon = true;
        }
    }
}
