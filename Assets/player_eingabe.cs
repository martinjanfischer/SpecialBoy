using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_eingabe : MonoBehaviour
{
    public float meineGeschwindigkeit = 10.0f;
    public float meineSprungGeschwindigkeit = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tz = Input.GetAxis("Vertical") * meineGeschwindigkeit;
        tz *= Time.deltaTime;
        float tx = Input.GetAxis("Horizontal") * meineGeschwindigkeit;
        tx *= Time.deltaTime;
        float ty = 0;
        if (Input.GetKey(KeyCode.Space))
        {
            ty = meineSprungGeschwindigkeit * Time.deltaTime;
        }
        transform.Translate(tx, ty, tz);

    }
}
