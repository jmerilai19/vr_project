using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
	public int mode = 0;
	
	public GameObject vase;
	public GameObject vase_red;
	int vaseLayer0;
	int vaseLayer1;
	
	public GameObject cameraLeft;
	public GameObject cameraRight;
	
	public GameObject OVRRig;
	
	public GameObject stuff;
	public GameObject player;
	
    // Start is called before the first frame update
    void Start()
    {
        vaseLayer0 = LayerMask.NameToLayer("Left");
		vaseLayer1 = LayerMask.NameToLayer("Default");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void updateMode() {
		print(mode);
		if (mode == 1) {
			vase_red.gameObject.SetActive(true);
			vase.gameObject.layer = vaseLayer0;
		} else if (mode == 2) {
			cameraLeft.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Right;
			cameraRight.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Left;
		} else if (mode == 3) {
			cameraLeft.transform.localScale = new Vector3(5, 1, 1);
			cameraRight.transform.localScale = new Vector3(5, 1, 1);
		} else if (mode == 4) {
			cameraLeft.gameObject.GetComponent<Blur> ().enabled = true;
		} else if (mode == -1) {
			vase_red.gameObject.SetActive(false);
			vase.gameObject.layer = vaseLayer1;
		} else if (mode == -2) {
			cameraLeft.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Left;
			cameraRight.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Right;
		} else if (mode == -3) {
			cameraLeft.transform.localScale = new Vector3(1, 1, 1);
			cameraRight.transform.localScale = new Vector3(1, 1, 1);
		} else if (mode == -4){
			cameraLeft.gameObject.GetComponent<Blur> ().enabled = false;
		} else {
			vase_red.gameObject.SetActive(false);
			vase.gameObject.layer = vaseLayer1;
			
			cameraLeft.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Left;
			cameraRight.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Right;
			
			OVRRig.transform.localScale = new Vector3(1, 1, 1);
			
			cameraLeft.transform.localScale = new Vector3(1, 1, 1);
			cameraRight.transform.localScale = new Vector3(1, 1, 1);
			
			cameraLeft.gameObject.GetComponent<Blur> ().enabled = false;
		}
	}
}
