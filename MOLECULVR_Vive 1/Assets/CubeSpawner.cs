using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

    public GameObject atom;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Atom")
        {
            atom.GetComponent<AtomProperties>().atomName = other.GetComponent<AtomProperties>().atomName;

            Instantiate(atom, transform.position, Quaternion.identity);

        }

    }
}
