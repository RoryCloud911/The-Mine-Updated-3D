using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartTriggerScript : MonoBehaviour
{
    public GameObject closedoor;
    public GameObject opendoor;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            closedoor.SetActive(false);
            opendoor.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
