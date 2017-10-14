using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchInterface : MonoBehaviour {
	
	void Update () {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began) {
            if (EventSystem.current.IsPointerOverGameObject()) {
                Debug.Log("Clicked on the UI");
            }
        }
    }
}
