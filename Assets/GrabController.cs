using UnityEngine;
using System.Collections;

public class GrabController : MonoBehaviour {

    public TextMesh tooltip;

    public ElementProperties properties;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("something collided");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("this is an element");
            tooltip.text = collision.gameObject.GetComponent<ElementProperties>().elementName;
            
        }
    }
}
