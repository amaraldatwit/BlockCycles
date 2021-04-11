using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticPiece : MonoBehaviour
{

    int active_count;
    //public GameObject piece;
    public Sprite active_piece;
    public Sprite inactive_piece;
    // Start is called before the first frame update
    void Start()
    {
        active_count = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }    

    void OnTriggerExit2D(Collider2D other){
        Debug.Log("Collide over");
        active_count--;
        if(active_count <= 0){
                for(int i = 0; i < this.gameObject.transform.childCount; i++){
                    this.gameObject.transform.GetChild(i).gameObject.GetComponent<Image>().sprite = inactive_piece;
                }
            }
    }
    void OnTriggerEnter2D(Collider2D other){
            Debug.Log("Collided with grid");
            active_count++;
            if(active_count > 0){
                for(int i = 0; i < this.gameObject.transform.childCount; i++){
                    this.gameObject.transform.GetChild(i).gameObject.GetComponent<Image>().sprite = active_piece;
                }
            }
        }
}
