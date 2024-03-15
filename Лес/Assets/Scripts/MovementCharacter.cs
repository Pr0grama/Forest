using UnityEngine;

[CreateAssetMenu(fileName = "MovementCharacter", menuName = "Movement/MovementCharacter", order = 1)]
public class MovementCharacter : ScriptableObject
{
    [SerializeField] private bool _visibleCursor = false;
    [SerializeField] private float _movementSpeed = 1f;
    [SerializeField] private float _angleSpeed = 150f;
    [SerializeField] private float _gravity = 15f;

    public bool VisibleCursor => _visibleCursor;
    public float MovementSpeed => _movementSpeed;
    public float AngularSpeed => _angleSpeed;
    public float Gravity => _gravity;
}
