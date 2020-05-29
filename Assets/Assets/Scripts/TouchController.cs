using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 velocity;
    private float screenWidth;
    // Start is called before the first frame update
    void Start()
    {
        screenWidth = Screen.width;
        velocity = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0;


            //move left
            if (touch.position.x < screenWidth / 2 && touch.phase == TouchPhase.Began)
            {
                if (velocity.x > -1)
                {
                    velocity += Vector3.left;
                }
            }

            //move right
            if (touch.position.x < screenWidth / 2 && touch.phase == TouchPhase.Began)
            {
                if (velocity.x < 1)
                {
                    velocity += Vector3.left;
                }
            }
            transform.position = Vector3.Lerp(transform.position, velocity, speed * Time.deltaTime);
        }
    }
}
