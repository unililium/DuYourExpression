using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    public Character character;
    public List<Button> buttons;
    public Text textSpace;
    public Enums.Expression currentExpression;
    private int score;

    void Start()
    {
        score = 0;
    }

    void Score(int value)
    {
        score += value;
        textSpace.text = "Score: " + score;
    }
}
