using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    float lenght, startX, startY;
    public GameObject Cam;
    public float parallaxX;
    public float parallaxY;
    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    // Update is called once per frame
    void Update()
    {
        float temp = (Cam.transform.position.x * (1-parallaxX));
        float distX = (Cam.transform.position.x * parallaxX);
        float distY = (Cam.transform.position.y * parallaxY);
        transform.position = new Vector3(startX + distX,startY+distY,transform.position.z);

        if(temp > startX+lenght) startX += lenght;
        else if(temp < startX-lenght) startX -= lenght;
    }
}
