using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public Enums.Expression expression;
    private int expvalue;
    public List<Choice> activeChoices;
    public List<Choice> choices;
    public List<string> responses;
    Animator anim;

    void Start() {
        this.anim = GetComponent<Animator>();

        this.expression = Enums.Expression.Idle;
    }

    private void Update()
    {
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            int random = Random.Range(0, 200);
            this.expression = Enums.Expression.Idle;
            if (random == 1)
            {
                this.expression = Enums.Expression.Smile;
                anim.Play("smile");
            }
            else if (random == 2)
            {
                this.expression = Enums.Expression.Wink;
                anim.Play("wink");
            }
            else if (random == 3)
            {
                this.expression = Enums.Expression.Wow;
                anim.Play("wow");
            }
        }
    }
}
