using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MoveBot
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

     override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var direction = opponent.transform.position -
            NPS.transform.position;
        NPS.transform.rotation = Quaternion.Slerp(NPS.transform.rotation,
            Quaternion.LookRotation(direction), rotSpeed * Time.deltaTime);
        NPS.transform.Translate(0, 0, Time.deltaTime * speed);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
    }
}
