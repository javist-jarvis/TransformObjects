using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speedScale;
    private MethodsTransformObjects _methodsTransformObjects = new();
    private void Update()
    {
        _methodsTransformObjects.ScaleObject(_speedScale, transform);
    }
}
