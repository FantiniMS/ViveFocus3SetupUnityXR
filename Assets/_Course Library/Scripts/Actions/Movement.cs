using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveX()
    {
        Vector3 movement = new Vector3();
        movement.x += 1;

        movement.Normalize();

        transform.Translate(movement * movementSpeed * Time.deltaTime);
    }
}
