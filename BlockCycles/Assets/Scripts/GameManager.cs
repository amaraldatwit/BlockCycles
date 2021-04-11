using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    
    public GameObject[] ghostPieces;
    private GameObject activePiece;

    private Vector2 mousePos;


    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = new Vector2(mousePos.x, mousePos.y);

        

        if(Input.GetKeyDown("1")){
                if(activePiece!=null){
                    Destroy(activePiece);
                }
                activePiece = Instantiate(ghostPieces[0], pos,Quaternion.identity);
            }
        if(Input.GetKeyDown("2")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[1], pos,Quaternion.identity);
            }
        if(Input.GetKeyDown("3")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[2], pos,Quaternion.identity);
            }
        if(Input.GetKeyDown("4")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[3], pos,Quaternion.identity);
            }
        if(Input.GetKeyDown("5")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[4], pos,Quaternion.identity);
            }
        if(Input.GetKeyDown("6")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[5], pos,Quaternion.identity);
            }
        if(Input.GetKeyDown("7")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[6], pos,Quaternion.identity);
            }
    }
}
