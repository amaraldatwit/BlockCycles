using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPiece : MonoBehaviour
{[SerializeField]
    private GameObject finalObject;
    private Quaternion rotation;
    private Vector2 mousePos;
    private Vector2 objPos;

    
    private int z;
    public float x= -1.7f;
    public float y= -1.3f;


    // Update is called once per frame
    void Update()
    {
        // Gets mouse position relative to main camera
        //mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //objPos = Camera.main.WorldToScreenPoint(transform.position);
        //mousePos = Input.mousePosition;
        Vector2 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Rounds mouse position values to get whole numbers
        //transform.position = new Vector2(Mathf.Round(mousePos.x)+x, Mathf.Round(mousePos.y)+y);
        transform.position = new Vector2(targetPos.x, targetPos.y);
        if(Input.GetKeyDown("r")){
            z=z+90;
            if(z==360) z = 0;
            rotation=Quaternion.Euler(0,0,z);
            transform.rotation=rotation;
            
        
        }


        if(Input.GetMouseButtonDown(0)){
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));
            transform.position = new Vector2(mousePos.x, mousePos.y);
        
            Instantiate(finalObject, transform.position, rotation);
        
        }
    
    
    }
}
