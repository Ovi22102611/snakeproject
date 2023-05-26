
using UnityEngine;

public class Snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;
    private List<Transform> _snakePieces //make segments
        private void Start()
    {
        _snakePieces = new List<Transform>();
        _snakePieces.Add(this.transform);
    }
    private void Update() // checking Input
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        }
    }
    private void FixedUpdate() // the physics of snake movement
    {
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f);
    }

    private void gettingTaller()
    {
        Instantiate(this._snakePiecesPrefab);
        snakePieces.position = _snakePieces[_snakePieces.Count - 1].position;
        _snakePieces.Add(_snakePieces);

        private void ResetPosition()
        {
            for (int i= 1; i< _snakePieces.count; i++)
            {
                Destroy(_snakePieces[i]);
                this.transform.position = Vector3.zero;
            }
        }
    }

}
