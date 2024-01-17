using UnityEngine;

public class Pieces : MonoBehaviour
{
    [SerializeField] private float Minx, MaxX, MinY, MaxY;

    
    private void Start()
    {
        

        transform.position = new Vector2(Random.Range(Minx, MaxX), Random.Range(MinY, MaxY));
    }
    
}
