using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField]
    private GameObject finalObject;

    private Vector2 mousePos;

    [SerializeField]


    // Update is called once per frame
    void Update()
    {
        // Gets mouse position relative to main camera
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Rounds mouse position values to get whole numbers
        transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));
    
        if(Input.GetMouseButtonDown(0)){
            //mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));
        
            //Instantiate(finalObject, transform.position, Quaternion.identity);
        
        }
    
    
    }
}
