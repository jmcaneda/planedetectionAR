using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class GridMove : MonoBehaviour
{
    [SerializeField] private ARRaycastManager _arRaycastManager;
    [SerializeField] private GameObject _gridPrefab;
    [SerializeField] private GameObject _objectPrefad;
    [SerializeField] private Camera _camera;
    public GameObject _gridInstance;
    public GameObject _objectInstance;


    void Update()
    {
        Vector2 screenCenter = _camera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        _arRaycastManager.Raycast(screenCenter, hits, TrackableType.PlaneWithinBounds);

        if (hits.Count > 0)
        {
            Pose hitPose = hits[0].pose;

            if (_gridInstance == null)
            {
                _gridInstance = Instantiate(_gridPrefab, hitPose.position, hitPose.rotation);
            }
            else
            {
                _gridInstance.transform.SetPositionAndRotation(hitPose.position, hitPose.rotation);
            }
        }

        if (_objectInstance == null & _gridInstance != null & Input.GetMouseButtonDown(0))
        {
            _objectInstance = Instantiate(_objectPrefad, _gridInstance.transform.position, _gridInstance.transform.rotation);
        }

    }

}
