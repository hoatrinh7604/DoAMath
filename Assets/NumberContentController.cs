using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberContentController : MonoBehaviour
{
    [SerializeField] GameObject showNumberPrefab;
    [SerializeField] Transform content;
    [SerializeField] List<GameObject> list = new List<GameObject>();

    public void Spaw(int leng)
    {
        ClearContent();
        list.Clear();
        list = new List<GameObject>();
        for (int i = 0; i < leng; i++)
        {
            GameObject item = Instantiate(showNumberPrefab, Vector3.zero, Quaternion.identity, content);
            item.transform.localPosition = Vector3.zero;
            list.Add(item);
        }
    }

    public void UpdateInfo(int index, string value)
    {
        list[index].GetComponent<ShowNumberController>().SetInfo(value);
    }

    private void ClearContent()
    {
        for (int i = 0; i < content.childCount; i++)
        {
            Destroy(content.GetChild(i).gameObject);
        }
    }
}
