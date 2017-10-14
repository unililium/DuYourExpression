using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour {

    public string phrase;
    public int value;

    public Choice(string phrase, int value)
    {
        this.phrase = phrase;
        this.value = value;
    }
}
