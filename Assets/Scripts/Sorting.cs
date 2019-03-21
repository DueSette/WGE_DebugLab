using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorting : MonoBehaviour {

    public int[] numbers;
    public int[] numbs;

    int i, j;   //Iterators

    void Start ()
    {   
        SelectionSort();
        InsertionSort();
    }

    //Insertion Sort
    void InsertionSort()
    {       
        for(j = 1; j < numbs.Length; j++)
        {
            int i = j;
            while(i > 0 && numbs[i-1] > numbs[i])
            {
                int temp1, temp2;
                temp1 = numbs[i];
                temp2 = numbs[i - 1];

                numbs[i] = temp2;
                numbs[i - 1] = temp1;
                i--;
            }
        }
    }

    //Selection Sort
    void SelectionSort()//add int[] target here to make this function work with any int array
    {
        for (j = 0; j < numbers.Length - 1; j++)
        {
            int min = j;

            for (i = j + 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[min])
                {
                    min = i;
                }
            }
            if (min != j)
            {
                int temp1, temp2;
                temp1 = numbers[j];
                temp2 = numbers[min];

                numbers[j] = temp2;
                numbers[min] = temp1;
            }
        }
    }

    void Function()
    {

    }
}
