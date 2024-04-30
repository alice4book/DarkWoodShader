using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private CharacterController characterController;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        characterController.Move(move * Time.deltaTime * speed) ; 
    }
}
