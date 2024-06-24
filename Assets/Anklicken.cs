using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anklicken : MonoBehaviour
{
    private const string PointKey = "Points";

    public int Points { get; private set; }

    void Start()
    {

        Points = PlayerPrefs.GetInt(PointKey, 0);
        Printpoints();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
            {
                Points++;
                Printpoints();
                {


                }

            }
        }
    }

    private void Printpoints()
    {
        Debug.LogFormat("Points: {0}", Points);
    }
}
