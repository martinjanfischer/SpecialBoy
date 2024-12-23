using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class player_eingabe : MonoBehaviour
{
    public float meineGeschwindigkeit = 10.0f;
    public float meineSprungGeschwindigkeit = 2.0f;
    Vector3 Spawnposition;
    public float Grenzex = 1;
    public float Grenzez = 1;
    public float Grenzey = 1;
    public GameObject Kamera;

	float tx = 0.0f;
	float ty = 0.0f;
	float tz = 0.0f;
	bool isGrounded = true;
	Rigidbody rb;

	// Start is called before the first frame update
	void Start()
    {
        Spawnposition = transform.position;
		rb = GetComponent<Rigidbody>();
	}

	public void MyInputActionMovementVirtualJoystick(InputAction.CallbackContext _context)
	{
		Vector2 joystickPosition = _context.ReadValue<Vector2>();
		tx = joystickPosition.x;
		tz = joystickPosition.y;

		tz *= meineGeschwindigkeit * Time.deltaTime;
		tx *= meineGeschwindigkeit * Time.deltaTime;
	}
	void OnCollisionStay()
	{
		isGrounded = true;
	}

	public void MyInputActionJumpVirtualJoystick(InputAction.CallbackContext _context)
	{
		if (isGrounded && _context.phase == InputActionPhase.Performed)
		{
			Vector3 jump = new Vector3(0.0f, meineSprungGeschwindigkeit, 0.0f);
			rb.AddForce(jump, ForceMode.Impulse);
			isGrounded = false;
		}
	}

	// Update is called once per frame
	void Update()
    {
        if (Kamera)
        {
            Vector3 forward = Vector3.Cross(Kamera.transform.right, Vector3.up);
            transform.position += forward * tz + Kamera.transform.right * tx + Vector3.up * ty;
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
        