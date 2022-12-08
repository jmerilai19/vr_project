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
		if (mode == 1) {
			vase_red.gameObject.SetActive(true);
			vase.gameObject.layer = vaseLayer0;
		} else {
			vase_red.gameObject.SetActive(false);
			vase.gameObject.layer = vaseLayer1;
		}
	}
}
