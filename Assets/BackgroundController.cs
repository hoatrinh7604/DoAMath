using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] GameObject[] background;
    [SerializeField] GameObject[] listAnimals;
    [SerializeField] List<int> listIDAnimalsSpawn;
    [SerializeField] int currentIndex;

    public int HandleShowBG()
    {
        currentIndex = Random.Range(0, background.Length);

        for(int i = 0; i<background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
        }

        background[currentIndex].gameObject.SetActive(true);

        return currentIndex;
    }

    public int GetMaxAnimal()
    {
        int maxpos = background[currentIndex].GetComponent<PositionController>().GetLength();
        if (listAnimals.Length < maxpos)
            return listAnimals.Length;
        return maxpos;
    }

    public void SpawAnimals(int amount)
    {
        List<int> listAni = new List<int>();
        List<int> listAniTemp = new List<int>();

        for (int i = 0; i < listAnimals.Length; i++)
        {
            listAni.Add(0);
            listAniTemp.Add(i);
        }

        background[currentIndex].GetComponent<PositionController>().Init();
        for (int i = 0; i < amount; i++)
        {
            int index = listAniTemp[Random.Range(0, listAniTemp.Count)];
            listAni[index] = 1;
            listAniTemp = new List<int>();
            for (int j = 0; j < listAni.Count; j++)
            {
                if (listAni[j] == 0)
                {
                    listAniTemp.Add(j);
                }
            }

            background[currentIndex].GetComponent<PositionController>().SpawAnimal(listAnimals[index]);
            listIDAnimalsSpawn.Add(index);
        }
    }

    public void UpdateListIDSpawn(int removeID)
    {
        List<int> temp = new List<int>();

        for(int i = 0; i< listIDAnimalsSpawn.Count; i++)
        {
            if(listIDAnimalsSpawn[i] != removeID)
            {
                temp.Add(listIDAnimalsSpawn[i]);
            }
        }

        listIDAnimalsSpawn = temp;
    }

    public int GetRandomIDAnimalExist()
    {
        if (listIDAnimalsSpawn.Count == 0)
            return -1;
        return listIDAnimalsSpawn[Random.Range(0, listIDAnimalsSpawn.Count)];
    }
}
