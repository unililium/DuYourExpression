using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    private Enums.Expression expression;
    private int expvalue;
    public List<Choice> choices;

    void Start() {
        choices.Add(new Choice("cadrega", 1));
        choices.Add(new Choice("baluba", 2));
        choices.Add(new Choice("mandragola", 3));
        choices.Add(new Choice("borraccia", 0));
    }

    public void ChangeExpression(int value)
    {
        expvalue += value;
        switch(expvalue) {
            default:
                return;
        }
    }

    public Choice NextChoice() {
        return choices[Random.Range(0, choices.Count)];
    }
}
