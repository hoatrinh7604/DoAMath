using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    [SerializeField] Transform[] listPos;
    private int[] listIndex;
    private List<int> listIDAnimals;

    public void Init()
    {
        listIndex = new int[listPos.Length];
        listIDAnimals = new List<int>();
    }

    public void SpawAnimal(GameObject animal)
    {
        int index = RandomPos();
        GameObject ani = Instantiate(animal, Vector3.zero, Quaternion.identity, listPos[index]);
        ani.transform.localPosition = Vector3.zero;
        listIDAnimals.Add(ani.GetComponent<AnimalController>().GetID());
    }

    public int RandomPos()
    {
        List<int> currentPos = new List<int>();

        for(int i = 0; i < listIndex.Length; i++)
        {
            if(listIndex[i] == 0)
            {
                currentPos.Add(i);
            }
        }

        int index = currentPos[Random.Range(0, currentPos.Count)];
        listIndex[index] = 1;
        return index;
    }

    public Transform[] GetList()
    {
        return listPos;
    }

    public int GetLength()
    {
        return listPos.Length;
    }

    public List<int> GetListIDAnimals()
    {
        return listIDAnimals;
    }
}
