using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticPiece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If sharing an edge with the grid, then become active
        //Should static pieces blocks be considered a group, and any shared edge activates the group?
        //If static piece collides with grid blocks then activate all children
        //If static piece does not collide with grid blocks then deactivate all children
        
    }
}
