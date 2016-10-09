using UnityEngine;
using System.Collections;

public class RecycleBin : MonoBehaviour {

    // instance variables

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider atom)
    {
        if (atom.gameObject.tag == "Atom")
        {
            Destroy(atom.gameObject);
        }

    }
}
