
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public Boxcollider2D BoxArea;

    private void RandomGrid()
    {
        Bounds bounds = this.GridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);


        private void Trigger2D(Collider2D other)
        {
     if (other.tag = "Player")
            {
                RandomGrid();
            }
        }
    }
}