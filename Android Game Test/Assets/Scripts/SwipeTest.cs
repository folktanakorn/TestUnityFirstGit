using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTimeSwipe;
    public float minSwipeDistance;

    float startTimeTouch;
    float endTimeTouch;

    Vector3 startPositionTouch;
    Vector3 endPositionTouch;

    float swipeDistance;
    float swipeTime;

    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                startTimeTouch = Time.time;
                startPositionTouch = touch.position;
            }else if (touch.phase == TouchPhase.Ended)
            {
                endTimeTouch = Time.time;
                endPositionTouch = touch.position;

                swipeDistance = (endPositionTouch - startPositionTouch).magnitude ;
                swipeTime = endTimeTouch - startTimeTouch;

                if (swipeTime < maxTimeSwipe && swipeDistance > minSwipeDistance)
                {

                    Swipe();
                }
            }
        }
    }

    void Swipe()
    {
        Vector2 distance = endPositionTouch - startPositionTouch;

        if (Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
        {
            Debug.Log("Horizontal Swipe");
            if (distance.x > 0 )
            {
                Debug.Log("Right");
            }
            if (distance.x < 0)
            {
                Debug.Log("Right");
            }
        }
        else if(Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
        {
            Debug.Log("Vertical Swipe");
            if (distance.y > 0)
            {
                Debug.Log("Up");
                player.GetComponent<Player>().Jump();
            }
            if (distance.y < 0)
            {
                Debug.Log("Down");
            }
        }
    }
}
