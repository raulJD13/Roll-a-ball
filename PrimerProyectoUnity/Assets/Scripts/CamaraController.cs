using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start se llama antes de la primera actualización del frame.
    void Start()
    {
        if (player != null)
        {
            offset = transform.position - player.transform.position;
        }
        else
        {
            Debug.LogError("El objeto jugador no está asignado.");
        }
    }

    // LateUpdate se llama una vez por frame después de que todas las funciones de Update hayan sido completadas.
    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
        else
        {
            Debug.LogWarning("El objeto jugador ha sido destruido o no está asignado.");
        }
    }
}
