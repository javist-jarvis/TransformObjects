using UnityEngine;

public class ComplexTransform : MonoBehaviour
{
    [SerializeField] private float _speedScale;
    [SerializeField] private float _speedTranslate;
    [SerializeField] private float _speedRotate;
    
    private MethodsTransformObjects _methodsTransformObjects = new();

    private void Update()
    {
        _methodsTransformObjects.ScaleObject(_speedScale, transform);
        _methodsTransformObjects.TranslateObject(_speedTranslate, transform);
        _methodsTransformObjects.RotateObject(_speedRotate, transform);
    }
}
