﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
//using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public UnityEvent<Vector2> OnMovementInput, OnPointerInput;
    public UnityEvent OnAttack;


    private void Update()
    {
        //OnMovementInput?.Invoke(movement.action.ReadValue<Vector2>().normalized);
        OnMovementInput?.Invoke(new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")));
        OnPointerInput?.Invoke(GetPointerInput());
        if(Input.GetMouseButtonDown(0))
            OnAttack?.Invoke();
    }

    private Vector2 GetPointerInput()
    {
        //Vector3 mousePos = pointerPosition.action.ReadValue<Vector2>();
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gate"))
        {
            SceneManager.LoadScene(1);
        }
    }

    //private void OnEnable()
    //{
    //    attack.action.performed += PerformAttack;
    //}

    //private void PerformAttack(InputAction.CallbackContext obj)
    //{
    //    OnAttack?.Invoke();
    //}

    //private void OnDisable()
    //{
    //    attack.action.performed -= PerformAttack;
    //}
}
