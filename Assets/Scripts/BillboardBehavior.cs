using UnityEngine;

public class BillboardBehavior : MonoBehaviour
{
    Transform tracked;

    [SerializeField] [Range(0.0125f, 0.5f)] float LERP;

    void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("Player");

        if (!g)
        {
            Debug.LogError("No Player Tag in Scene!");

            this.enabled = false;
        }

        else
        {
            tracked = g.transform;
        }
    }

    
    void Update()
    {
        Vector3 forward = transform.position - tracked.position;
        forward.y = 0f;
        forward = forward.normalized;

        Quaternion destination = Quaternion.LookRotation(forward, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, destination, LERP);
    }
}
