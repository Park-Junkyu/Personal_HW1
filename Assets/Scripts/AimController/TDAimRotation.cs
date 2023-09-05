using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDAimRotation : MonoBehaviour
{
    //[SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private SpriteRenderer characterRenderer;
    //[SerializeField] private Transform armPivot;

    private MoveController _controller;

    private void Awake()
    {
        _controller = GetComponent<MoveController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimdirection)
    {
        RotateArm(newAimdirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;

        //armRenderer.flipY = Mathf.Abs(rotZ) > 90f;
        //characterRenderer.flipY = armRenderer.flipY;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        //armPivot.rotation = Quaternion.Euler(0,0, rotZ);
    }

}
