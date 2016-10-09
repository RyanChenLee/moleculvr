using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AtomProperties : MonoBehaviour {

    public string atomName;
    public Text clipboardFront;
    public Text clipboardBack;
    public GameObject clipboard;

    public string elementName;


    void Start()
    {
        clipboard = GetComponentInParent<ElementProperties>().clipboard;
        clipboardFront = GetComponentInParent<ElementProperties>().clipboardFront;
        clipboardBack = GetComponentInParent<ElementProperties>().clipboardBack;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Atom")
        {
            clipboardFront.text = (GetComponent<AtomProperties>().atomName);
            clipboardBack.text = (GetComponent<AtomProperties>().atomName);
            clipboard.GetComponentInChildren<VRTK.VRTK_ObjectTooltipCustom>().displayText = GetComponentInChildren<AtomProperties>().atomName;
            clipboard.GetComponentInChildren<VRTK.VRTK_ObjectTooltipCustom>().Reset();

        }
    }
}
