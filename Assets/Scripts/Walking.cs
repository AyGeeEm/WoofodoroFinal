using UnityEngine;

public class Walking : MonoBehaviour
{
    [SerializeField] float distanceToCover;
    [SerializeField] float speed;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        startPosition.x = -2.35f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 v = startPosition;
            v.x += distanceToCover * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
 
        
    }
}
 