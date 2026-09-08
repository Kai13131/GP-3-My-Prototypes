using UnityEngine;

public class Airlevel : MonoBehaviour
{
    public GameObject Player;
    public GameObject obstacle_2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            obstacle_2.SetActive(true);
            Debug.Log("test");
        }
    }
}
