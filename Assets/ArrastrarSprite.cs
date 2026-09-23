using UnityEngine;
using UnityEngine.InputSystem;

public class ArrastrarSprite : MonoBehaviour
{
    private Vector3 diferencia;

    private void OnMouseDown()
    {
        Vector3 posicionMouse = ObtenerPosicionMouse();
        diferencia = transform.position - posicionMouse;
    }

    private void OnMouseDrag()
    {
        Vector3 posicionMouse = ObtenerPosicionMouse();
        transform.position = posicionMouse + diferencia;
    }

    private Vector3 ObtenerPosicionMouse()
    {
        Vector3 posicion = Mouse.current.position.ReadValue();

        posicion.z = -Camera.main.transform.position.z;

        Vector3 posicionMundo = Camera.main.ScreenToWorldPoint(posicion);

        posicionMundo.z = transform.position.z;

        return posicionMundo;
    }
}