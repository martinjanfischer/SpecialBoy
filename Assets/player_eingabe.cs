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
    public GameObject camera;

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
        if (camera)
        {
            Vector3 forward = Vector3.Cross(camera.transform.right, Vector3.up);
            transform.position += forward * tz + camera.transform.right * tx + Vector3.up * ty;
        }

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
        