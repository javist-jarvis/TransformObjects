using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        transform.Translate(transform.forward * _moveSpeed * Time.deltaTime);
    }
}
