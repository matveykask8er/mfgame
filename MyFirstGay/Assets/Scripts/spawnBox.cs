using System.Collections;
using UnityEngine;

public class spawnBox : MonoBehaviour
{
    // private void Awake()
    //{
    //    rigidbody = GetComponent<Rigidbody2D>();
       
    //}
    public GameObject bomb;

    void Start ()
    {
        StartCoroutine(Spawn ());
    }
    IEnumerator Spawn ()
    {
        while (true)
        {
            Instantiate (bomb, new Vector2 (Random.Range(-2.5f, 2.5f), 5.7f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}


