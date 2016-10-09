using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Molecules : MonoBehaviour {

    public GameObject Diatomic;
    public GameObject Water;
    public GameObject Methane;
    public static Molecules molecules;
    public string[] WaterArray;
    public string[] DiatomicArray;
    public string[] MethaneArray;



    // Use this for initialization

    void Start()
    {
        DiatomicArray = new string[] { "Hydrogen", "Hydrogen" };
        WaterArray = new string[] { "Hydrogen", "Hydrogen", "Oxygen" };
        MethaneArray = new string[] { "Carbon", "Hydrogen", "Hydrogen", "Hydrogen", "Hydrogen" };
    }


}
