using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState(PlayerStateMachine currentContext, PlayerStateFactory1 playerStateFactory)
    :base (currentContext, playerStateFactory){}

    public override void EnterState(){

    }
    public override void UpdateState(){
        CheckSwitchState();
    }
    public override void ExitState(){

    }
    public override void CheckSwitchState(){

    }
    public override void InitializeSubState(){

    }   
}