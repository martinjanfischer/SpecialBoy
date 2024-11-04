using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_eingabe : MonoBehaviour
{
    public float meineGeschwindigkeit = 10.0f;
    public float meineSprungGeschwindigkeit = 2.0f;
    Vector3 Spawnposition;
    public float Grenzex = 1;
    public float Grenzez = 1;
    public float Grenzey = 1;

    // Start is called before the first frame update
    void Start()
    {
        Spawnposition = transform.position;
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

        // Wenn player position in x oder z richtung größer ist als die Grenze
        // dann bewege den player zurück auf die spawn position
        if (transform.position.x>Grenzex
            || transform.position.z > Grenzez
            || transform.position.y>Grenzey
            || transform.position.x < -Grenzex
            || transform.position.y< -Grenzey
            || transform.position.z< -Grenzez
            )
        {
            transform.position = Spawnposition;
        }

    }
}
        