using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour {

    string phrase;
    int value;

    public Choice(string phrase, int value)
    {
        this.phrase = phrase;
        this.value = value;
    }
}
