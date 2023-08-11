using UnityEngine;

public class DontDestroyGeneral : MonoBehaviour
{ 
    private Camera cam1;
    private Camera cam2;

    private void Awake()
    {
        // Find the cameras as children of the "camera" object
        cam1 = transform.Find("Camera2D").GetComponent<Camera>();
        cam2 = transform.Find("Camera3D").GetComponent<Camera>();
    }

    public void OnSceneChange()
    {
        // Detach the cameras from the "camera" object
        if (cam1 != null)
            cam1.transform.SetParent(null);
        if (cam2 != null)
            cam2.transform.SetParent(null);
    }

    public void OnSceneReload()
    {
        // Reattach the cameras to the "camera" object
        if (cam1 != null)
            cam1.transform.SetParent(transform);
        if (cam2 != null)
            cam2.transform.SetParent(transform);
    }
}

