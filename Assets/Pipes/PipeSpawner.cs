using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject pipe;
    [SerializeField]
    public float spawnRate;
    [SerializeField]
    public float variance = 2.5f;

    void Start()
    {
        StartCoroutine(CreatePipes());
    }

    IEnumerator CreatePipes()
    {
        while (true) 
        {
            yield return new WaitForSeconds(spawnRate);
            float yPos = Random.Range(-variance, variance);
            Vector3 position = new Vector3(transform.position.x, yPos, transform.position.z);
            Instantiate(pipe, position, gameObject.transform.rotation);
        }
    }
}
