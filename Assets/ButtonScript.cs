using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
	public int myMode = 1;
	public bool on = false;
	public Material materialOn;
    public Material materialDefault;
	public GameObject manager;
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
	
	public void toggleOn() {
		on = !on;
		if (on) {
			print("on");
			gameObject.GetComponent<MeshRenderer> ().material = materialOn;
			transform.Translate(Vector3.down * 0.04f);
			manager.gameObject.GetComponent<ManagerScript> ().mode = myMode;
			manager.gameObject.GetComponent<ManagerScript> ().updateMode();
		} else {
			print("off");
			gameObject.GetComponent<MeshRenderer> ().material = materialDefault;
			transform.Translate(Vector3.up * 0.04f);
			manager.gameObject.GetComponent<ManagerScript> ().mode = -myMode;
			manager.gameObject.GetComponent<ManagerScript> ().updateMode();
		}
	}
}
