using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float moveHorizontal;
    public float speed;
    public float xPosition;
    public GameObject pizzaProjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // add a boundary para hindi makalagpas sa playfield si player
        if(transform.position.x < -xPosition)
        {
            transform.position = new Vector3(-xPosition, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xPosition)
        {
            transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
        }

        moveHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(moveHorizontal * speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // launch projectile
            Instantiate(pizzaProjectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
