using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private playerController _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Basketball").GetComponent<playerController>();
    }
}
