using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform NextRoom;
    [SerializeField] private Transform BackRoom;
    [SerializeField] private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
            {  
                cam.MoveTheNewRoom(NextRoom);
            }
            else 
            {
                cam.MoveTheNewRoom(BackRoom);

            }
        }
    }
}
