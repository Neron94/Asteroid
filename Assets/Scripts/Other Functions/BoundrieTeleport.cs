using UnityEngine;

public class BoundrieTeleport : MonoBehaviour
{
    private enum BoundSide { Top, Bottom, Right, left };
    [SerializeField] private BoundSide _boundSide;
    [SerializeField] private float _leftRightOffset;
    [SerializeField] private float _topBottontOffset;

    private void OnTriggerEnter2D(Collider2D collisionObject)
    {
        float object_x = collisionObject.transform.position.x;
        float object_y = collisionObject.transform.position.y;

        if (_boundSide == BoundSide.Top)
        {
            collisionObject.transform.position = new Vector2
                (object_x, -object_y + _topBottontOffset);
        }
        else if (_boundSide == BoundSide.Bottom)
        {
            collisionObject.transform.position = new Vector2
                (object_x, Mathf.Abs(object_y) - _topBottontOffset);
        }
        else if (_boundSide == BoundSide.Right)
        {
            collisionObject.transform.position = new Vector2
                (-object_x + _leftRightOffset, 0);
        }
        else if (_boundSide == BoundSide.left)
        {
            collisionObject.transform.position = new Vector2
                (Mathf.Abs(object_x) - _leftRightOffset, 0);
        }
    }
}
