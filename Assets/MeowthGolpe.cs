using System;
using UnityEngine;

public class MeowthGolpe : MonoBehaviour
{
    private Animator animator;
    [SerializeField]
    private String nomeParametroTrigger;
    [SerializeField]
    private KeyCode teclaAtaque;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(teclaAtaque))
        {
            animator.SetTrigger(nomeParametroTrigger);
        }
    }
}
