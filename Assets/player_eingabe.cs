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
        float ty = Input.GetAxis("Vertical") * meineSprungGeschwindigkeit;
        ty *= Time.deltaTime;
        float tx = Input.GetAxis("Horizontal") * meineGeschwindigkeit;
        tx *= Time.deltaTime;
        transform.Translate(tx, ty, 0);

    }
}
