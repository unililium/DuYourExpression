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
        string text = character.choices[i].phrase;
        textSpace.text = text;
        int value = character.choices[i].value;
        Debug.Log(text + value);
    }
}
