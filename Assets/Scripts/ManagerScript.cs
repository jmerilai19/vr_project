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
	
	public GameObject buttonBlue;
	public GameObject buttonInvis;
	public GameObject buttonTilt;
	
	public GameObject cameraLeft;
	public GameObject cameraRight;
	
	public GameObject OVRRig;
	
	public GameObject stuff;
	
	public GameObject paintingL;
	public GameObject paintingR;
	public GameObject paintingLinv;
	public GameObject paintingRinv;
	
    void Start()
    {
        vaseLayer0 = LayerMask.NameToLayer("Left");
		vaseLayer1 = LayerMask.NameToLayer("Default");
    }
	
	public void updateMode() {
		//print(mode);
		if (mode == 1) {
			if (buttonInvis.gameObject.GetComponent<ButtonScript>().on) {
				buttonInvis.gameObject.GetComponent<ButtonScript>().toggleOn();
			}
			if (buttonTilt.gameObject.GetComponent<ButtonScript>().on) {
				buttonTilt.gameObject.GetComponent<ButtonScript>().toggleOn();
			}
			vase_red.gameObject.SetActive(true);
			vase.gameObject.layer = vaseLayer0;
			
			paintingLinv.gameObject.SetActive(true);
			paintingRinv.gameObject.SetActive(true);
			paintingL.gameObject.layer = vaseLayer0;
			paintingR.gameObject.layer = vaseLayer0;
		} else if (mode == 2) {
			cameraLeft.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Right;
			cameraRight.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Left;
		} else if (mode == 3) {
			if (buttonBlue.gameObject.GetComponent<ButtonScript>().on) {
				buttonBlue.gameObject.GetComponent<ButtonScript>().toggleOn();
			}
			vase.gameObject.layer = vaseLayer0;
			
			paintingL.gameObject.layer = vaseLayer0;
			paintingR.gameObject.layer = vaseLayer0;
		} else if (mode == 4) {
			cameraLeft.gameObject.GetComponent<Blur> ().enabled = true;
		} else if (mode == 5) {
			if (buttonBlue.gameObject.GetComponent<ButtonScript>().on) {
				buttonBlue.gameObject.GetComponent<ButtonScript>().toggleOn();
			}
			OVRRig.gameObject.GetComponent<OVRCameraRig>().tiltEnabled = true;
		
		} else if (mode == 6) {
			OVRRig.gameObject.transform.localScale = new Vector3(1, 1, 1);
		} 
		//////////////////////////////////////////////////
		else if (mode == -1) {
			vase_red.gameObject.SetActive(false);
			vase.gameObject.layer = vaseLayer1;
			
			paintingLinv.gameObject.SetActive(false);
			paintingRinv.gameObject.SetActive(false);
			paintingL.gameObject.layer = vaseLayer1;
			paintingR.gameObject.layer = vaseLayer1;
		} else if (mode == -2) {
			cameraLeft.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Left;
			cameraRight.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Right;
		} else if (mode == -3) {
			vase_red.gameObject.SetActive(false);
			vase.gameObject.layer = vaseLayer1;
			
			paintingL.gameObject.layer = vaseLayer1;
			paintingR.gameObject.layer = vaseLayer1;
		} else if (mode == -4){
			cameraLeft.gameObject.GetComponent<Blur> ().enabled = false;
		} else if (mode == -5){
			OVRRig.gameObject.GetComponent<OVRCameraRig>().tiltEnabled = false;
		} else if (mode == -6) {
			OVRRig.gameObject.transform.localScale = new Vector3(2, 2, 2);
		} else {
			vase_red.gameObject.SetActive(false);
			vase.gameObject.layer = vaseLayer1;
			
			paintingL.gameObject.layer = vaseLayer1;
			paintingR.gameObject.layer = vaseLayer1;
			
			cameraLeft.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Left;
			cameraRight.GetComponent<Camera>().stereoTargetEye = StereoTargetEyeMask.Right;
			
			OVRRig.transform.localScale = new Vector3(1, 1, 1);
			
			OVRRig.gameObject.GetComponent<OVRCameraRig>().tiltEnabled = false;
			
			cameraLeft.gameObject.GetComponent<Blur> ().enabled = false;
			
			paintingLinv.gameObject.SetActive(false);
			paintingRinv.gameObject.SetActive(false);
			
			OVRRig.gameObject.transform.localScale = new Vector3(2, 2, 2);
		}
	}
}
