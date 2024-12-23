using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualJoystickActivation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		if (SystemInfo.deviceType == DeviceType.Handheld)
		{
			this.gameObject.SetActive(true);
		}
		else if (SystemInfo.deviceType == DeviceType.Console)
		{
			this.gameObject.SetActive(false);
		}
		else if (SystemInfo.deviceType == DeviceType.Desktop)
		{
			this.gameObject.SetActive(false);
		}
		else if (SystemInfo.deviceType == DeviceType.Unknown)
		{
			this.gameObject.SetActive(false);
		}
	}
}
