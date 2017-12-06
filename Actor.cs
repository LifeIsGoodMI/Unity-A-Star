using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    private int curIndex;


    public void Move(Vector3[] path)
    {
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
