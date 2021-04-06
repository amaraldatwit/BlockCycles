using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPiece : MonoBehaviour
{[SerializeField]
    private GameObject finalObject;
    private Quaternion rotation;
    private Vector2 mousePos;

    
    private int z;
    public float x=(float)-2.5;
    public float y= 1;


    // Update is called once per frame
    void Update()
    {
        // Gets mouse position relative to main camera
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Rounds mouse position values to get whole numbers
        transform.position = new Vector2(Mathf.Round(mousePos.x)+x, Mathf.Round(mousePos.y)+y);
        if(Input.GetKeyDown("r")){
            z=z+90;
            if(z==360) z = 0;
            rotation=Quaternion.Euler(0,0,z);
            transform.rotation=rotation;
            
        
        }


        if(Input.GetMouseButtonDown(0)){
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));
        
            Instantiate(finalObject, transform.position, rotation);
        
        }
    
    
    }
}
