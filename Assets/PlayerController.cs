using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int currentDir;
    [SerializeField] GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        currentDir = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ChangeDirection();
        }
    }

    public void ChangeDirection()
    {
        currentDir++;
        if (currentDir > 3) currentDir = 0;

        transform.localRotation = Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, 90 * currentDir);
        Color[] col = GamePlayController.Instance.template;
        GetComponent<Image>().color = GamePlayController.Instance.template[Random.Range(0, col.Length)];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Piece")
        {
            if (currentDir <2 && collision.gameObject.GetComponent<PieceController>().GetDirection() < 2
                || currentDir > 1 && collision.gameObject.GetComponent<PieceController>().GetDirection() > 1)
            {
                SpawEffect();
                GamePlayController.Instance.UpdateScore();
                Destroy(collision.gameObject);
            }
            else
            {
                // Game over
                Destroy(collision.gameObject);
                GamePlayController.Instance.GameOver();
            }
        }
    }

    public void SpawEffect()
    {
        GameObject eff = Instantiate(effect, Vector2.zero, Quaternion.identity);
        eff.transform.SetParent(transform);
        eff.transform.position = transform.position;
        eff.transform.localPosition = Vector3.zero;
        eff.transform.localScale = Vector3.one;
        Destroy(eff, 0.5f);
    }
}
