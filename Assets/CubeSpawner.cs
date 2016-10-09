using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

    public GameObject atom;
    
	void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Atom")
        {
            atom.GetComponent<AtomProperties>().atomName = other.GetComponent<AtomProperties>().atomName;
            atom.GetComponent<AtomProperties>().clipboard = other.GetComponent<AtomProperties>().clipboard;
            atom.GetComponent<AtomProperties>().clipboardFront = other.GetComponent<AtomProperties>().clipboardFront;
            atom.GetComponent<AtomProperties>().clipboardBack = other.GetComponent<AtomProperties>().clipboardBack;

            Instantiate(atom, transform.position, Quaternion.identity);

        }

    }
}
