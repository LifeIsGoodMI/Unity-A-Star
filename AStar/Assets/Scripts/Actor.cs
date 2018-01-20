/// <summary>
/// Just a very basic actor, following the returned path of the AStarSearch method.
/// </summary>

using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    private int curIndex;


    public void Move(Vector3[] path)
    {
        // Target the next cell in the path when you're closer then 0.4 meters to the current.
        // Don't set this too low, otherwise the actor might get stuck.
        if ((path[curIndex] - transform.position).magnitude < 0.4f)
            curIndex++;
        if (curIndex >= path.Length)
            curIndex = 0;

        var direction = path[curIndex] - transform.position;

        if (direction != Vector3.zero)
        {
            var targetRot = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, Time.deltaTime * 2.0f);
        }

        var velocity = transform.forward * movementSpeed * Time.deltaTime;
        transform.position += velocity;
    }
}
