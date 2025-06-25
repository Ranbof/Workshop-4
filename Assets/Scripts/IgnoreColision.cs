using UnityEngine;

public class IgnoreColision : MonoBehaviour
{
    private float Reboundforce { get; } = 2f;

    void Update()
    {
        
    }

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("RedSphere"))
        {
            collision.rigidbody.isKinematic = true;
            collision.collider.enabled = false;
        }

        if (collision.rigidbody.CompareTag("BlueSphere"))
        {
            var rigidBody = collision.rigidbody;
            rigidBody.AddForce(rigidBody.linearVelocity * Reboundforce, ForceMode.Impulse);
            Debug.Log("blue");

        }
	}
}