using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector;
    [SerializeField] float speed;
    Vector3 startingPos;
    Vector3 endPos;
    float movementFactor;
    
    void Start()
    {
        startingPos = transform.position;
        endPos = startingPos + movementVector;
    }

    void Update()
    {
        movementFactor = Mathf.PingPong(Time.time * speed, 1f);
        transform.position = Vector3.Lerp(startingPos, endPos, movementFactor);
    }
}
