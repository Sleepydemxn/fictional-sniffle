using UnityEngine;

public class tv : MonoBehaviour
{
    public void On(Color col, Vector2 Pos)
    {
        GetComponent<SpriteRenderer>().color = col;
        transform.position = new Vector2(transform.position.x + Pos.x,transform.position.y + Pos.y);
    }

    public void Off(Color col, Vector2 Pos)
    {
        GetComponent<SpriteRenderer>().color = col;
        transform.position = new Vector2(transform.position.x + Pos.x*-1 ,transform.position.y + Pos.y*-1);
    }
}
