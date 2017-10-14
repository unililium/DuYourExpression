using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    private Enums.Expression expression;
    private int expvalue;
    public Choice[] choices;

    public void ChangeExpression(int value)
    {
        expvalue += value;
        switch(expvalue) {
            default:
                return;
        }
    }

    public void NextChoices() {

    }
}
