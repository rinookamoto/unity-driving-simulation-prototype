
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [Header("Camera Settings")]
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera driverCamera;

    [Header("Audio Settings")]
    [SerializeField] private AudioListener mainAudioListener;
    [SerializeField] private AudioListener driverAudioListener;

    // true = Driver Camera
    private bool isDriverCamera = false;

    void Start()
    {
        // Validate camera references
        if (mainCamera == null || driverCamera == null)
        {
            Debug.LogError("Camera references are missing!");
            enabled = false;
            return;
        }

        // Get AudioListener components if they are not assigned
        if (mainAudioListener == null)
            mainAudioListener = mainCamera.GetComponent<AudioListener>();

        if (driverAudioListener == null)
            driverAudioListener = driverCamera.GetComponent<AudioListener>();

        // Start with the main camera active
        SwitchCamera(false);
    }

    void Update()
    {
        // Toggle between cameras when the C key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera(!isDriverCamera);
        }
    }

    void SwitchCamera(bool useDriverCamera)
    {
        isDriverCamera = useDriverCamera;

        // Enable the selected camera and disable the other
        mainCamera.enabled = !isDriverCamera;
        driverCamera.enabled = isDriverCamera;

        // Switch the active AudioListener
        if (mainAudioListener != null)
            mainAudioListener.enabled = !isDriverCamera;

        if (driverAudioListener != null)
            driverAudioListener.enabled = isDriverCamera;

        Debug.Log(isDriverCamera
            ? "Driver Camera ON"
            : "Main Camera ON");
    }
}
