using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public Character character;

    public Button button_a;
    public Button button_b;

    void Start() {
    }

    void Update() {
        if(Input.GetButtonDown("Fire1")) {
            character.ChangeExpression(0);
        } else if(Input.GetButtonDown("Fire2")) {
            character.ChangeExpression(1);
        }
	}

    public void OnClickChange(Button button) {
        Choice choice = button.GetComponentInChildren<Choice>();
        character.ChangeExpression(choice.value);
        Debug.Log(choice.phrase);
        Text text = button.GetComponentInChildren<Text>();
        text.text = choice.phrase;
        
        character.NextChoices();
    }
}
