namespace VRTK
{
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic;

    public class ClearButton : MonoBehaviour
    {
        // instance variables
        public GameObject clearButton;
        public Container container;

        void onCollisionEnter(Collider collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (clearButton.GetComponent<VRTK.VRTK_InteractableObject>().IsUsing()) //isGrabbed? isTouched?
                {
                    // update front ent
                    for (int i = 0; i < container.atomsInContainer.Count; i++)
                    {
                        Destroy(container.currentAtoms[i].gameObject);
                    }
                    Debug.Log("currentAtoms " + container.currentAtoms.Count.ToString());

                    // update backend
                    Debug.Log("backend: before reset-" + container.atomsInContainer.ToString());
                    container.atomsInContainer.Clear(); // resets to empty
                    container.currentAtoms.Clear(); // resets to empty
                    Debug.Log("backend: after reset-" + container.atomsInContainer.ToString());

                }
            }
        }
    }
}
        