using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speedRotate;
    private MethodsTransformObjects _methodsTransformObjects = new();

    private void Update()
    {
        _methodsTransformObjects.RotateObject(_speedRotate, transform);
    }
}
