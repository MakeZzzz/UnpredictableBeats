using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Idle : StateMachineBehaviour
{
    
    private Animator _animator;
    private  int Speed = Animator.StringToHash("speed");
    

    [UsedImplicitly]
    public void OnStateEnter()
    {
        _animator = FindObjectOfType<Animator>();
        _animator.SetFloat(Speed, 0);
    }
}
