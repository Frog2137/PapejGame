using UnityEngine;

public class KremowkaScore : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    { 

        if (other.gameObject.tag == "Player")
        {
            Destroy(GetComponent<SpriteRenderer>());
            Destroy(GetComponent<BoxCollider2D>());
            ScoreManager.score = ScoreManager.score + 1;
        }
  
    }
}


