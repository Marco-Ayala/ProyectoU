using UnityEngine;
using TMPro;

public class ControlarFuente : MonoBehaviour
{
    private TextMeshProUGUI texto;
    private float tamañoOriginal;

    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
        tamañoOriginal = texto.fontSize;
    }

    public void AumentarFuente()
    {
        texto.fontSize += 5;
    }

    public void DisminuirFuente()
    {
        texto.fontSize -= 5;

        if (texto.fontSize < 10)
        {
            texto.fontSize = 10;
        }
    }

    public void RestablecerFuente()
    {
        texto.fontSize = tamañoOriginal;
    }
}