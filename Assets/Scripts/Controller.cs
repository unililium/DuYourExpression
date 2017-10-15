using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public Character character;
    public List<Button> buttons;
    public Text textSpace;
    public Enums.Expression currentExpression;
    private int score;

    void Start() {
        currentExpression = Enums.Expression.Happy;
        score = 0;
    }

    public void OnClickChange(int exp) {
        if((Enums.Expression)exp == currentExpression) {
            score += 50;
            textSpace.text = "you're happy";
        } else {
            score -= 50;
        }
    }

    public void OnHoverShowText(int i) {
        //string text = character.activeChoices[i].phrase;
        //textSpace.text = text;
    }

    public void Resetext() {
        textSpace.text = "";
    }

    void ChangeActiveExpression() {
        currentExpression = character.expression;
    }
}
