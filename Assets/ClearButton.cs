namespace VRTK
{
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic;

    public class ClearButton : MonoBehaviour
    {
        // instance variables
        public static Event eventOn;
        public GameObject clearButton;
        public Container container;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void clearContents()
        {
            if (clearButton.GetComponent<VRTK.VRTK_InteractableObject>().IsUsing()) //isGrabbed? isTouched?
            {
                // update backup
                Debug.Log("before " + container.atomsInContainer.ToString());
                container.atomsInContainer = new List<string>();
                Debug.Log("after " + container.atomsInContainer.ToString());

                //update front end
                
            }
        }
    }
}
        