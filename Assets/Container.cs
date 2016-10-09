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
    int i;

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

                for (i = 0; i < numberOfAtoms; i++)
                {
                    Destroy(currentAtoms[i].gameObject);
                }
                
            }
            if (Equals(atomsInContainer.ToArray(), molecules.DiatomicArray))
            {
                Instantiate(molecules.Diatomic, molecules.Diatomic.transform.position, molecules.Diatomic.transform.rotation);

                for (i = 0; i < numberOfAtoms; i++)
                {
                    Destroy(currentAtoms[i].gameObject);
                }
                
            }
            if (Equals(atomsInContainer.ToArray(), molecules.MethaneArray))
            {
                Instantiate(molecules.Methane, molecules.Methane.transform.position, molecules.Methane.transform.rotation);

                for (i = 0; i < numberOfAtoms; i++)
                {
                    Destroy(currentAtoms[i].gameObject);
                }
                
            }

            
            /*if (molecules.moleculesDatabase.ContainsKey(atomsInContainer)) {
                Debug.Log("Match!");
                Instantiate(molecules.moleculesDatabase[atomsInContainer], transform.position, Quaternion.identity);

            }*/

        }   
        }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Atom")
        {
            tempAtom = other.gameObject.GetComponent<AtomProperties>().atomName;
            atomsInContainer.Remove(tempAtom);
            currentAtoms.Remove(other.gameObject);

            numberOfAtoms--;
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
