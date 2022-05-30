using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentController : MonoBehaviour
{
    [SerializeField] GameObject buttonNumberPreFab;
    [SerializeField] Transform content;

    private List<string> list;

    public void SpawButton(List<string> arr)
    {
        ClearContent();

        list = new List<string>();
        for(int i =0;i < arr.Count; i++)
        {
            list.Add(arr[i]);
        }

        for(int i = 0; i < arr.Count; i++)
        {
            GameObject item = Instantiate(buttonNumberPreFab, Vector3.zero, Quaternion.identity, content);
            item.transform.localPosition = Vector3.zero;

            int index = GetRandomIndex();
            item.GetComponent<ButtonNumberController>().SetInfo(list[index]);

            list[index] = "";
        }
    }

    private int GetRandomIndex()
    {
        List<int> temp = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != "")
                temp.Add(i);
        }

        int index = Random.Range(0, temp.Count);
        return temp[index];
    }

    private void ClearContent()
    {
        for(int i = 0; i < content.childCount; i++)
        {
            Destroy(content.GetChild(i).gameObject);
        }
    }
}
