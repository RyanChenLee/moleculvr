using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Container : MonoBehaviour {



    public List<string> atomsInContainer;
    public List<GameObject> currentAtoms = new List<GameObject>();
    public Dictionary<string[], GameObject> moleculeDatabase = new Dictionary<string[], GameObject>();
    private string tempAtom;
    public Molecules molecules;
    int numberOfAtoms = 0;
    

    

	// Use this for initialization
	void Start () {
        //Instantiate(molecules.moleculesDatabase(atomsInContainer), transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update () {
        
	}

    void checkContainer(List<string> atomsInContainer)
    {
        Debug.Log("checking...");
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Atom")
        {
            tempAtom = other.gameObject.GetComponent<AtomProperties>().atomName;
            atomsInContainer.Add(tempAtom);
            currentAtoms.Add(other.gameObject);

            numberOfAtoms++;

            atomsInContainer.Sort();
            if (Equals(atomsInContainer.ToArray(), molecules.WaterArray))
            {
                Instantiate(molecules.Water, molecules.Water.transform.position, molecules.Water.transform.rotation);
                for (int i = 0; i < numberOfAtoms; i++)
                {
                    Destroy(currentAtoms[i].gameObject);
                }
                currentAtoms.Clear();
            }
           
            other.gameObject.GetComponent<VRTK.VRTK_InteractableObject>().isGrabbable = false;

            /*if (molecules.moleculesDatabase.ContainsKey(atomsInContainer)) {
                Debug.Log("Match!");
                Instantiate(molecules.moleculesDatabase[atomsInContainer], transform.position, Quaternion.identity);

            }*/

        }

    }
    public bool Equals(string[] atoms, string[] molecule)
    {
        if (atoms.Length != molecule.Length)
        {
            return false;
        }
        for (int i = 0; i < atoms.Length; i++)
        {
            if (atoms[i] != molecule[i])
            {
                return false;
            }
        }
        return true;
    }
}
