using UnityEngine;

public class DoubleClickDetector : MonoBehaviour
{
    [SerializeField] private bool doubleClicked = false;
    [SerializeField] private float catchTime = 0.2f;

    private float lastClickTime = 0f;

    public bool IsDoubleClicked()
    {
        return doubleClicked;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time - lastClickTime < catchTime)
            {
                // Detecta doble clic
                doubleClicked = !doubleClicked;
            }
            else
            {
                // Actualiza el tiempo del último clic
                lastClickTime = Time.time;
            }
        }
    }
}
