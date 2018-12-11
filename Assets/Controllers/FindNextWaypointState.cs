using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNextWaypointState : StateMachineBehaviour
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        EnemyMovement enemyMovement = animator.gameObject.GetComponent<EnemyMovement>();
        enemyMovement.FindNextWaypointState_Enter();
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
