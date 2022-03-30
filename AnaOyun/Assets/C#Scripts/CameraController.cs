using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //oda kamerasý 
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;
    //kullanýcý takip

    [SerializeField]private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float camareSpped;
    private float lookAhead;


    private void Update()
    {
        //kamera takip
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);

        //kullanýcý takip
        transform.position = new Vector3(player.position.x+lookAhead, transform.position.y, transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * camareSpped);
    }

    public void MoveTheNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
    }

}
