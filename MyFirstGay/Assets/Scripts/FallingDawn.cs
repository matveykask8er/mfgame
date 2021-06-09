using UnityEngine;

public class FallingDawn : MonoBehaviour {
   
    [SerializeField]
    private float fallSpeed = 3f;

    void Update()
    {
     transform.position -= new Vector3 (0, fallSpeed * Time.deltaTime, 0);   
    }
}
