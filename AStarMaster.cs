/// <summary>
/// Initializes grid & algorithm. Constructs a path on user input.
/// </summary>

using UnityEngine;

public class AStarMaster : MonoBehaviour
{
    public int width, length;

    public Vector2 start, goal;

    private Grid2D grid;
    public Algorithm algorithm;

    public Cell[] path;


    private void Awake()
    {
        grid = new Grid2D(width, length);
        algorithm = new Algorithm(grid, start, goal);
    }


    private void Start()
    {
        grid.Generate();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            path = algorithm.AStarSearch();
    }
}
