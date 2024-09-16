using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class einsammeln : MonoBehaviour
{
    totalScore totalScoreScipt;
    void start()
    {
        totalScoreScipt = GameObject.Find("totalScore").GetComponent<totalScore>();
    }

    //update is called once per frame
    void update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

        }
    }
}