using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameObject discPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move player horizontally
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 position = transform.position;
        position.x = moveX;
        transform.position = position;

        // Drop disc
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Clone prefab
            Instantiate(discPrefab, transform.position, Quaternion.identity);
        }
    }
}
