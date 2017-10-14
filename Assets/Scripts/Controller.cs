using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public Character character;
    public List<Button> buttons;
    public Text textSpace;

    void Start() {
    }

    void Update() {
	}

    public void OnClickChange(int i) {
        int value = character.activeChoices[i].value;
        character.NextChoice(i);
    }

    public void OnHoverShowText(int i) {
        string text = character.activeChoices[i].phrase;
        textSpace.text = text;
    }

    public void Resetext() {
        textSpace.text = "";
    }
}
