using UnityEngine;

public class TranslateUp : MonoBehaviour
{
    [SerializeField] private float _speedTranslate;
    private MethodsTransformObjects _methodsTransformObjects = new();

    private void Update()
    {
        _methodsTransformObjects.TranslateObject(_speedTranslate, transform);
    }
}
