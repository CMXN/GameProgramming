using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpiritHurt : BspiritState
{
    public BossSpiritHurt(BossSpirit bossSpirit, BspiritStateMachine stateMachine, BossSpiritData bossData, string animBoolName) : base(bossSpirit, stateMachine, bossData, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
        bossSpirit.TurnOnHeart();
    }

    public override void Exit()
    {
        base.Exit();
        bossSpirit.TurnOffHeart();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if(bossSpirit.counter > 7)
        {
            stateMachine.ChangeState(bossSpirit.BossSecondSummon);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}