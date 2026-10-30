using UnityEngine;

public class MoveOncomingVehicle : MonoBehaviour
{
    public float speed = 15.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
