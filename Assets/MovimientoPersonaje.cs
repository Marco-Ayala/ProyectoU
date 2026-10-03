using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        Vector2 movimiento = Vector2.zero;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            movimiento.x = -1;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            movimiento.x = 1;
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            movimiento.y = 1;
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            movimiento.y = -1;
        }

        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}