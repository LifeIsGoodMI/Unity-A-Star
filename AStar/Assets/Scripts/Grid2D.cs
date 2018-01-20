/// <summary>
/// The underlying grid for the A* algorithm. Easily extendable to a 3D grid.
/// </summary>

using UnityEngine;

[System.Serializable]
public class Grid2D
{
    public int width, length;

    public Cell[] cells;


    private Grid2D() { }

    public Grid2D(int width, int length)
    {
        this.width = width;
        this.length = length;
    }


    public void Generate()
    {
        cells = new Cell[width * length];

        for (int w = 0; w < width; w++)
        {
            for (int l = 0; l < length; l++)
            {
                int index = w * length + l;
                var cell = new Cell(new Vector2(w, l));

                cells[index] = cell;
            }
        }
    }


    public Cell FindCellByPosition(Vector2 pos)
    {
        int x = (int)pos.x;
        int y = (int)pos.y;

        if (x >= 0 && x < width && y >= 0 && y < length)
        {
            int index = x * length + y;
            var cell = cells[index];
            return cell;
        }

        throw new System.Exception(string.Format("There is no cell on the grid corresponding to position {0}", pos));
    }

    public Cell[] GetMooreNeighbours(Cell current)
    {
        var result = new Cell[8];

        int x = (int)current.position.x;
        int y = (int)current.position.y;

        int[] indices = new int[] 
        {
            x * length + (y + 1),
            (x + 1) * length + y,
            x * length + (y - 1),
            (x - 1) * length + y,
            (x - 1) * length + (y + 1),
            (x + 1) * length + (y + 1),
            (x - 1) * length + (y - 1),
            (x + 1) * length + (y - 1)
        };


        // North
        if (y < length - 1)
            result[0] = cells[indices[0]];

        // East
        if (x < width - 1)
            result[1] = cells[indices[1]];

        // South
        if (y > 0)
            result[2] = cells[indices[2]];

        // West
        if (x > 0)
            result[3] = cells[indices[3]];


        // North-West
        if (y < length - 1 && x > 0)
            result[4] = cells[indices[4]];

        // North-East
        if (y < length - 1 && x < width - 1)
            result[5] = cells[indices[5]];

        // South-West
        if (y > 0 && x > 0)
            result[6] = cells[indices[6]];

        // South-East
        if (y > 0 && x < width - 1)
            result[7] = cells[indices[7]];

        return result;
    }
}
