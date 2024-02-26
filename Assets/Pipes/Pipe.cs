using UnityEngine;

public class Pipe : MonoBehaviour
{
    private float _lifeTime = 5.0f;

    void Start()
    {
        Destroy(gameObject, _lifeTime);
    }
}
