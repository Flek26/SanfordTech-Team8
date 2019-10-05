using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateColor : MonoBehaviour
{
    public Renderer cubeRenderer;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.SetColor("_Color", Color.Lerp(Color.white, Color.red, Mathf.PingPong(Time.time, 1)));
    }
}
