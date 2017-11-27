using UnityEngine;

[System.Serializable]
public class Cell
{
    public Vector2 position;

    public float cost, heuristic;
    public float f
    {
        get { return cost + heuristic; }
    }

    public Cell parent;


    private Cell() { }

    public Cell(Vector2 position)
    {
        this.position = position;
    }
}
