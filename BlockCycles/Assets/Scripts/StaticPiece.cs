using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticPiece : MonoBehaviour
{

    bool active;
    //public GameObject piece;
    public Sprite active_piece;
    public Sprite inactive_piece;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        //Sprite active_piece =  Resources.Load<Sprite>("Assets\\Board Assets\\BackTile_05");
        //Sprite inactive_piece =  Resources.Load<Sprite>("Assets\\Board Assets\\BackTile_05_Red");
    }

    // Update is called once per frame
    void Update()
    {
        //If sharing an edge with the grid, then become active
        //Should static pieces blocks be considered a group, and any shared edge activates the group?
        //If static piece collides with grid blocks then activate all children
        //If static piece does not collide with grid blocks then deactivate all children
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Collided with grid");
        if(active == false){
            for(int i = 0; i < this.gameObject.transform.childCount; i++){
                SpriteRenderer s = this.gameObject.transform.GetChild(i).GetComponent<SpriteRenderer>();
                s.sprite = active_piece;
            }
            active = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        Debug.Log("Collide over");
        if(active == true){
            for(int i = 0; i < this.gameObject.transform.childCount; i++){
                Sprite s = this.gameObject.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite;
                s = inactive_piece;
            }
            active = false;
        }
    }

}
