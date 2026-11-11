using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    [Tooltip("Velocidad de rotacion de las sirenas en grados por segundo")]
    public float rotationSpeed = 180f;

    void Update()
    {
        // Grados por segundo * segundos del frame actual = rotacion suave e independiente del framerate
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
