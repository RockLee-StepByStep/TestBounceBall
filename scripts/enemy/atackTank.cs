using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atackTank : MoveBot
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        NPS.GetComponent<tankAI>().StartFiring();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPS.transform.LookAt(opponent.transform.position);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPS.GetComponent<tankAI>().StopFiring();
    }
}
