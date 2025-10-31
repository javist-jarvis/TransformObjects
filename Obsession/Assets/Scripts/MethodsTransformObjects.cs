using UnityEngine;

public class MethodsTransformObjects : MonoBehaviour
{
    internal void RotateObject(float speedRotate, Transform transform)
    {
        transform.Rotate(transform.up * speedRotate * Time.deltaTime);
    }

    internal void ScaleObject(float speedScale, Transform transform)
    {
        transform.localScale += Vector3.one * speedScale * Time.deltaTime;
    }

    internal void TranslateObject(float speedTranslate, Transform transform)
    {
        transform.Translate(Vector3.up * speedTranslate * Time.deltaTime);
    }
}
