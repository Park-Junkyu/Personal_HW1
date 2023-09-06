using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    public RuntimeAnimatorController[] animController;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        gameManager.instance.player = this;
    }

    void OnEnable()
    {
        ChangeChar();
    }
    void Start()
    {

    }

    void Update()
    {

    }
    public void ChangeChar()
    {
        anim.runtimeAnimatorController = animController[gameManager.instance.PlayerId];
    }
}
