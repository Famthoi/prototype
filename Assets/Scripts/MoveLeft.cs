using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    float speed=20;
    private PlayerController playerControllerScript;
    int leftMost = -9;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript=GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver != true)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftMost && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
