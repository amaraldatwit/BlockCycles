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
        if(Input.GetKeyDown("1")){
                if(activePiece!=null){
                    Destroy(activePiece);
                }
                activePiece = Instantiate(ghostPieces[0], transform.position,Quaternion.identity);
            }
        if(Input.GetKeyDown("2")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[1], transform.position,Quaternion.identity);
            }
        if(Input.GetKeyDown("3")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[2], transform.position,Quaternion.identity);
            }
        if(Input.GetKeyDown("4")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[3], transform.position,Quaternion.identity);
            }
        if(Input.GetKeyDown("5")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[4], transform.position,Quaternion.identity);
            }
        if(Input.GetKeyDown("6")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[5], transform.position,Quaternion.identity);
            }
        if(Input.GetKeyDown("7")){
            if(activePiece!=null){
                    Destroy(activePiece);
                }
               activePiece = Instantiate(ghostPieces[6], transform.position,Quaternion.identity);
            }
    }
}
