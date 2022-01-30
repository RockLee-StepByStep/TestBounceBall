using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBot : StateMachineBehaviour
{
    public GameObject NPS;
    public GameObject opponent;

    public float speed = 4.0f;
    public float rotSpeed = 1.0f;
    public float accuracy = 1.0f;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPS = animator.gameObject;
        opponent = NPS.GetComponent<tankAI>().GetPLayer();

       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
