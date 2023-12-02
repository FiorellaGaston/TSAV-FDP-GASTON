using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float raycastRange = 10f;

    void Update()
    {
        // Se verifica si se presiona el botón de mouse izquierdo (Fire1)
        if (Input.GetButtonDown("Fire1"))
        {
            // Se obtiene la posición y la dirección de la cámara
            Camera cam = Camera.main; // Puedes cambiar esto según la configuración de tu escena
            Vector3 raycastOrigin = cam.transform.position;
            Vector3 raycastDirection = cam.transform.forward;

            RaycastHit hitInfo;

            // Se realiza el raycast, ignorando específicamente el objeto "BasicMotionsDummyModel"
            if (Physics.Raycast(raycastOrigin, raycastDirection, out hitInfo, raycastRange) && hitInfo.collider.gameObject.name != "BasicMotionsDummyModel")
            {
                // Si el raycast colisiona con un objeto que no es el jugador, se muestra su nombre en la consola
                Debug.Log("Objeto impactado: " + hitInfo.collider.gameObject.name);
            }
        }
    }
}