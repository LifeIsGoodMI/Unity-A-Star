/// <summary>
/// Initializes grid and algorithm. Constructs a path on user input.
/// </summary>

using UnityEngine;

public class AStarMaster : MonoBehaviour
{
    public int width, length;

    public Vector2 start, goal;

    private Grid2D grid;
    public Algorithm algorithm;

    public Cell[] path;

    public Actor actor;


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
            path = algorithm.AStarSearch(); // Receive the constructed path.

        // Lets an actor follow the path, really really basic.
        if (path != null && path.Length > 0)
        {
            // Ideally, you would *not* be doing this stuff every frame. 
            // Just keeping it simple here :)
            var positions = new List<Vector3>();
            path.ToList().ForEach(c => positions.Add(new Vector3(c.position.x, 0, c.position.y)));

            actor.Move(positions.ToArray());
        }
    }
}
