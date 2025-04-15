using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public InputActionReference fireAction;
    public InputActionReference horizontalAction;
    public InputActionReference verticalAction;

    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;

    private Rigidbody rb;

    private Animator animator;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 movement = this.transform.position;
        //Ajout du mouvement horizontal
        movement += Vector3.right * speed * horizontalAction.action.ReadValue<float>() * Time.deltaTime;
        //Ajout du mouvement vertical
        movement += Vector3.forward * speed *verticalAction.action.ReadValue<float>() * Time.deltaTime;

        rb.MovePosition(movement);
        
        if (fireAction.action.triggered )
        {
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
        }

        UpdateAnimator();

        /*if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.back * speed * Time.deltaTime;
        }*/


    }

    void UpdateAnimator()
    {
        
        Vector2 localSpeed = WorldToLocalSpeed( new Vector2(horizontalAction.action.ReadValue<float>(), verticalAction.action.ReadValue<float>()),
           this.transform.eulerAngles.y );
        animator.SetFloat("Horizontal", localSpeed.x);
        animator.SetFloat("Vertical", localSpeed.y);
    }

    public Vector2 WorldToLocalSpeed(Vector2 worldSpeed, float characterRotationDegrees)
    {
        // Convert character rotation from degrees to radians
        float characterRotationRadians = characterRotationDegrees * Mathf.Deg2Rad;

        // Calculate the rotated vector components
        float localX = worldSpeed.x * Mathf.Cos(characterRotationRadians) + worldSpeed.y * Mathf.Sin(characterRotationRadians);
        float localY = -worldSpeed.x * Mathf.Sin(characterRotationRadians) + worldSpeed.y * Mathf.Cos(characterRotationRadians);

        // Return the local speed vector
        return new Vector2(localX, localY);
    }
}
