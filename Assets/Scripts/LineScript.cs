using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
	public LineRenderer line;
	public Transform pos0;
	public Transform pos1;
	public GameObject button0;
	
    // Start is called before the first frame update
    void Start()
    {
        //72CEFF
    }

    // Update is called once per frame
    void Update()
    {
		Physics.Raycast(transform.parent.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 50f);
        line.SetPosition(0, transform.parent.position);
		line.SetPosition(1, hitInfo.point);
		if (hitInfo.transform.gameObject.tag == "RedButton") {
			if (OVRInput.GetDown(OVRInput.Button.One)) {
				hitInfo.transform.gameObject.GetComponent<ButtonScript>().toggleOn();
			}
		}
		
		if (OVRInput.GetDown(OVRInput.Button.Two)) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
