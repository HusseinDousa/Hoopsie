using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buzzerTime : MonoBehaviour
{
    private UiManager _Manager;
    public GameObject _fireWorkPrefab;
    private AudioSource _TickTock;

    // Start is called before the first frame update
    void Start()
    {
        _Manager = GameObject.Find("Canvas").GetComponent<UiManager>();
        _TickTock = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 2, 0) * Time.deltaTime * 30f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _Manager.addTime();

            Instantiate(_fireWorkPrefab, transform.position, Quaternion.identity);
            _TickTock.Play();
            Destroy(this.gameObject, 1.0f);
        }
    }

}
