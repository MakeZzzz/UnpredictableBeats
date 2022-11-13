using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    public float _movementSpeed = 2f;
   [SerializeField] private Animator _animator;
    private static readonly int Speed = Animator.StringToHash("speed");
    private static readonly int kick1 = Animator.StringToHash("kick_1");
    private static readonly int kick2 = Animator.StringToHash("kick_2");

    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    void Update()
    {
      
        if (Input.GetMouseButtonUp(0))
        {
            var randomAnimation = Random.Range(0, 2);
            switch (randomAnimation)
            {
                case 0:
                    _animator.SetTrigger(kick1);
                    break;
                case 1:
                    _animator.SetTrigger(kick2);
                    break;
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            var vertical = Input.GetAxis("Vertical") * _movementSpeed;
            transform.Translate(Vector3.forward * vertical * Time.deltaTime);
            _animator.SetFloat(Speed, 1);
           
        }

        if (Input.GetKey(KeyCode.S))
        {
            var vertical = Input.GetAxis("Vertical") * _movementSpeed;
            transform.Translate(Vector3.forward * vertical * Time.deltaTime);
            _animator.SetFloat(Speed, -1);
        }
        
    }
    private void FixedUpdate()
    {
        _animator.SetFloat(Speed, 0);
    }
}
