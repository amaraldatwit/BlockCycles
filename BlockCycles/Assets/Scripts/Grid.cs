using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    // -2: Inactive static piece, -1: Invalid, 0: empty active spot, 1: filled active spot
    private int[,] grid;

    public Grid(){

        grid = new int[11,11];
        Debug.Log("Created Default Grid with height: " + 11 + " and width: " + 11 +" .");

        for(int i = 0; i < grid.GetLength(0); i++){
            for(int j = 0; j < grid.GetLength(1); j++){
                grid[i, j] = 0;
            }
        }
    }

    public Grid(int[,] g){
        grid = g;
        Debug.Log("Created Grid with level supplied matrix. Size: " + grid.GetLength(0) + ", " + grid.GetLength(1));
    }

    public bool winCheck(){
        for(int i = 0; i < grid.GetLength(0); i++){
            for(int j = 0; j < grid.GetLength(1); j++){
                if(grid[i, j] == 0){
                    return false;
                }
            }
        }
        return true;
    }

    void Update(){
        
    }

    
}

