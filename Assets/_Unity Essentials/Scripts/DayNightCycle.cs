using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Seconds it takes for a full day cycle")]
    public float dayLengthInSeconds = 60f;

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees divided by how many seconds a day lasts
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate the light around the X axis
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}