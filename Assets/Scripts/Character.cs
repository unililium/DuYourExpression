using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    private Enums.Expression expression;
    private int expvalue;
    public List<Choice> activeChoices;
    public List<Choice> choices;
    public List<string> responses;
    public List<Animation> animations;

    void Start() {
        choices.Add(new Choice("cadrega", 1));
        choices.Add(new Choice("baluba", 2));
        choices.Add(new Choice("mandragola", 3));
        choices.Add(new Choice("borraccia", 0));
        for (int i = 0; i < 3; i++) {
            activeChoices.Add(choices[i]);
        }
    }

    public void ChangeExpression(int value)
    {
        expvalue += value;
        if (expvalue > 0 && expvalue < 5) {
            expression = Enums.Expression.Angry;
        }
        else if (expvalue < 8) {
            expression = Enums.Expression.Sad;
        }
        else {
            expression = Enums.Expression.Neutral;
        }
    }

    public void NextChoice(int i) {
        ChangeExpression(activeChoices[i].value);
        activeChoices[i] = choices[Random.Range(0, choices.Count)];

    }
}
