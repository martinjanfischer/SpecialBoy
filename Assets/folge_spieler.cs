using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folge_spieler : MonoBehaviour
{
    public GameObject m_spieler;
    public float m_abstand;
    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_spieler)
        {
            transform.position = m_spieler.transform.position - transform.forward * m_abstand;
        }
    }
}
