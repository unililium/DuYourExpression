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
        int random = Random.Range(0, 30);
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            this.expression = Enums.Expression.Idle;
            if (random == 1)
            {
                anim.Play("smile");
                this.expression = Enums.Expression.Smile;
            }
            else if (random == 2)
            {
                anim.Play("wink");
                this.expression = Enums.Expression.Wink;
            }
            else if (random == 3)
            {
                anim.Play("wow");
                this.expression = Enums.Expression.Wow;
            }
        }
    }

    private IEnumerator WaitForAnimation(Enums.Expression expression, string animname)
    {
        anim.Play(animname);
        this.expression = expression;
        yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length + anim.GetCurrentAnimatorStateInfo(0).normalizedTime + 1);
        this.expression = Enums.Expression.Idle;
    }

    public void ChangeExpression(int value)
    {
    }

    public void NextChoice(int i) {
        ChangeExpression(activeChoices[i].value);
        activeChoices[i] = choices[Random.Range(0, choices.Count)];

    }
}
