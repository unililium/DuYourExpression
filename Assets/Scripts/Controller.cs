using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public Character character;
	
	void Update() {
        if(Input.GetButtonDown("Fire1")) {
            character.ChangeExpression(0);
        } else if(Input.GetButtonDown("Fire2")) {
            character.ChangeExpression(1);
        }
	}
}
