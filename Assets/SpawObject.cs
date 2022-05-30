using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawObject : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject circle;
    [SerializeField] float timeDelay;

    [SerializeField] Transform minPos;
    [SerializeField] Transform maxPos;

    private int times;
    private float time;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > timeDelay)
        {
            time = 0;
            Spaw();

            times++;
            if(times > 5)
            {
                timeDelay -= 0.5f;
                if (timeDelay < 1.5f) timeDelay = 1.5f;
                times = 0;
            }
        }
    }

    public void Spaw()
    {
        GameObject obj = Instantiate(circle, Vector2.zero, Quaternion.identity);
        obj.GetComponent<CircleController>().RandomColor();
        obj.transform.SetParent(transform);
        //obj.transform.localPosition = Vector2.zero;
        obj.transform.localScale = Vector3.one;

        float x = Random.Range(minPos.position.x, maxPos.position.x);
        float y = Random.Range(minPos.position.y, maxPos.position.y);
        obj.transform.position = new Vector2(x, y);

        
    }
}
