using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    private int width;
    private int height;
    private int[,] grid;

    public Grid(int w, int h){
        this.width = w;
        this.height = h;

        grid = new int[w, h];
    }
}

