using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    private int[,] grid;

    public Grid(){

        grid = new int[7, 7];
        Debug.Log("Created Grid with height: " + 7 + " and width: " + 7 +" .");

        for(int i = 0; i < grid.GetLength(0); i++){
            for(int j = 0; j < grid.GetLength(1); j++){
                //grid[i, j] = 
            }
        }
    }

    
}

