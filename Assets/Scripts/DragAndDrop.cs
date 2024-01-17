using UnityEngine;
public class DragAndDrop : MonoBehaviour
{
    public bool InRightPlace;
    private Vector2 RightPlace;
    private GUI gamemaster;

    private void Awake()
    {
        gamemaster = GameObject.FindGameObjectWithTag("Master").GetComponent<GUI>();
        RightPlace = transform.position;
    }
    
    private void OnMouseUp()
    {
        if(Vector2.Distance(transform.position,RightPlace)  < .5f && !InRightPlace)
        {
            InRightPlace = true;
            transform.position = RightPlace;
            gamemaster.count += 1;
        }
    }
    private void OnMouseDrag()
    {
        if(!InRightPlace)
            this.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
    }

    

}
