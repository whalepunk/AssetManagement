using UnityEngine;

public class RotateTheHuTaoSphere : MonoBehaviour
{
    [SerializeField] float rotationSeed;

    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSeed * Time.deltaTime, 0));
    }
}
