using UnityEngine;
using System.Collections;

public class ResetLists : MonoBehaviour {
    public Container container;

	void OnTriggerEnter()
    {
        container.atomsInContainer.Clear();
        container.currentAtoms.Clear();
    }
}
