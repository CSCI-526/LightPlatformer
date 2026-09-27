using UnityEngine;

public class GameEndText : MonoBehaviour
{
    public float EndY = -20f; 
    public GameObject Tutorial;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < EndY)
        {
            Tutorial.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
