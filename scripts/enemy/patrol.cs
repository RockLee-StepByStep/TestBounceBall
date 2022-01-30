using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MoveBot
{
   
    GameObject[] wps;
    int currentWP;

    private void Awake()
    {
        wps = GameObject.FindGameObjectsWithTag("wp");
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        currentWP = 0;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (wps.Length == 0) return;
        if (Vector3.Distance(wps[currentWP].transform.position, NPS.transform.position) < accuracy)
        {
            currentWP++;
            if(currentWP >= wps.Length)
            {
                currentWP = 0;
            }
        }

        var direction = wps[currentWP].transform.position -
            NPS.transform.position;
        NPS.transform.rotation = Quaternion.Slerp(NPS.transform.rotation,
                                        Quaternion.LookRotation(direction),
                                        rotSpeed * Time.deltaTime);
        NPS.transform.Translate(0, 0, Time.deltaTime * speed);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
