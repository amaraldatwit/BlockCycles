using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    // -1: Inactive spot, 0: empty active spot, 1: filled active spot
    private int[,] grid;

    public Grid(){

        grid = new int[7, 7];
        Debug.Log("Created Grid with height: " + 7 + " and width: " + 7 +" .");

        for(int i = 0; i < grid.GetLength(0); i++){
            for(int j = 0; j < grid.GetLength(1); j++){
                grid[i, j] = 0;
            }
        }
    }

    public Grid(int[,] g){
        grid = g;
        Debug.Log("Created Grid with level supplied matrix.");
    }

    void Update(){

    }

    
}

