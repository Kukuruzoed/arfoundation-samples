using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;

public class TogglePassthrough : MonoBehaviour
{
    [SerializeField]
    private InputActionProperty toggleAction;

    private Camera camera;
    private bool skyboxEnable = true;

    private void Awake()
    {
        toggleAction.action.Enable();
        camera = FindAnyObjectByType<Camera>();
    }

    private void OnTogglePerformed(InputAction.CallbackContext obj)
    {
        if (camera)
        {
            skyboxEnable = !skyboxEnable;
            if (skyboxEnable) {
                camera.clearFlags = CameraClearFlags.Skybox; 
            }
            else
            {
                camera.clearFlags = CameraClearFlags.SolidColor;
            }
        }
    }

    private void OnEnable() => toggleAction.action.performed += OnTogglePerformed;

    private void OnDisable() => toggleAction.action.performed -= OnTogglePerformed;
}