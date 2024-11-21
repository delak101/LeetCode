public class Solution {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {

        char[,] grid = new char[m, n];  // a grid for all data i have
        int totalCells = m * n;         // total number of cells 
        // i'll get the total number then i'll decrement gaurded cells from it.

        HashSet<(int, int)> wallsSet = new HashSet<(int, int)>();   // wall HashSet
        HashSet<(int, int)> guardsSet = new HashSet<(int, int)>();  // gaurds HashSet
        HashSet<(int, int)> guarded = new HashSet<(int, int)>();    // gaurded cells HashSet

        // filling wall and gaurd sets
        for (int i = 0; i < walls.GetLength(0); i++)
        {
            wallsSet.Add((walls[i][0], walls[i][1]));    // add walls to wallset
        }

        for (int i = 0; i < guards.GetLength(0); i++)
        {
            guardsSet.Add((guards[i][0], guards[i][1])); // add gaurds to gaurdset
        }
                
        int[][] directions = new int[][] {
            new int[] { -1, 0 },  // north
            new int[] { 1, 0 },   // south
            new int[] { 0, -1 },  // west
            new int[] { 0, 1 }    // east
        };

        totalCells -= wallsSet.Count + guardsSet.Count;  
        // fist subtract the count of gaurds and walls from the the total cells

        // then iterate on each gaurd and get the gaurd's x,y coordinates
        foreach (var guard in guardsSet)
        {
            int gaurdX = guard.Item1, gaurdY = guard.Item2; // item1 is the first item in tuble which is the x axis or row index, item2 is the second item which is the y axis or the column indes

            // then iterate on each direction for every gaurd
            foreach (var dir in directions)
            {
                // we add the next index in that direction by incrementing the current x and y for the gaurd with the idex of the next direction
                int nextX = gaurdX + dir[0], nextY = gaurdY + dir[1];

                // then if that direction is in the range of the 2d array size
                // and if we hit another gaurd or a wall break the loop and stop going in that direction
                while (nextX >= 0 && nextX < m && nextY >= 0 && nextY < n)
                {
                    if (wallsSet.Contains((nextX, nextY)) || guardsSet.Contains((nextX, nextY)))
                        break;

                    // we're gonna check if there's a gaurd here add it (just in case it's not added)
                    if (!guarded.Contains((nextX, nextY)))
                    {
                        guarded.Add((nextX, nextY));
                        totalCells--; // decrement guarded cell from the total (ungaurded) count
                        // and keep going cus that other gaurd is gonna go in that direction anw.. what's the point of stopping?
                    }

                    // now move to the next cell as long as it keeps going
                    nextX += dir[0];
                    nextY += dir[1];
                }
            }
        }

        // finally return the amount of cells gaurded after decrementing 
        return totalCells;
    }
}