using UnityEngine;

public class GizmoBehaviour : MonoBehaviour
{
    [SerializeField] GameObject _grid;
    [SerializeField] DoubleClickDetector _detector;
    private float Speed;

    private void OnEnable()
    {
        Speed = 1.0f;
        _grid = GameObject.FindWithTag("GridController");
        _detector = GetComponent<DoubleClickDetector>();
    }

    private void Update()
    {
        if (!_detector.IsDoubleClicked())
        {
            var trackingPosition = _grid.GetComponent<GridMove>()._gridInstance.transform.position;

            if (Vector3.Distance(trackingPosition, transform.position) <= 0.1)
            {
                Vector3 direction = trackingPosition - transform.position;

                if (direction != Vector3.zero)
                {
                    var lookRotation = Quaternion.LookRotation(direction);
                    float rotationSpeed = 0.5f;
                    var rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
                    rotation *= Quaternion.Euler(0, Mathf.Deg2Rad * 30, 0);
                    transform.rotation = rotation;

                }

                return;
            }

            transform.position = Vector3.MoveTowards(transform.position, trackingPosition, Speed * Time.deltaTime);

        }
    }
}
