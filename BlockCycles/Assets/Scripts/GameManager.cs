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
    }
}
