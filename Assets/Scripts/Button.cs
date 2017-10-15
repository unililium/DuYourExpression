using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    Controller controller;
    Animator anim;
    public Character character;
    public int points = 50;
    AudioSource audiosource;
    public AudioClip[] audioclips;

    void Start() {
        this.anim = this.GetComponent<Animator>();
        this.audiosource = this.GetComponent<AudioSource>();
        this.controller = FindObjectOfType<Controller>();
    }

    public void OnClick(int value)
    {
        if ((Enums.Expression)value == character.expression)
        {
            anim.Play("Right");
            audiosource.PlayOneShot(audioclips[0]);
            controller.SendMessage("Score", points);
        }
        else
        {
            anim.Play("Wrong");
            audiosource.PlayOneShot(audioclips[1]);
            controller.SendMessage("Score", -points);
        }
    }
}
