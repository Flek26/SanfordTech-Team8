using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovment : MonoBehaviour
{
    public Camera maincamera;
    public GameObject gamer;
    public GameObject gamer1;
    public GameObject gamer2;
    public float speed = 60;
    public float scrollspeed = 3;
    public float updown = .02f;



    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            gamer2.transform.Rotate(Vector3.up * speed * Time.deltaTime);
            gamer.transform.Rotate(Vector3.up * speed * Time.deltaTime);
            gamer1.transform.Rotate(Vector3.up * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D)) {
                gamer.transform.Rotate(-Vector3.up * speed * Time.deltaTime);
                gamer1.transform.Rotate(-Vector3.up * speed * Time.deltaTime);
                gamer2.transform.Rotate(-Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
            maincamera.transform.position = new Vector3(maincamera.transform.position.x, maincamera.transform.position.y + updown, maincamera.transform.position.z);

        if (Input.GetKey(KeyCode.S))
            maincamera.transform.position = new Vector3(maincamera.transform.position.x, maincamera.transform.position.y - updown, maincamera.transform.position.z);

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");

            maincamera.transform.Translate(0, 0, scroll * scrollspeed, Space.World);


        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {

            float scroll = Input.GetAxis("Mouse ScrollWheel");
            maincamera.transform.Translate(0, 0, scroll * scrollspeed, Space.World);
        }

    }
}
