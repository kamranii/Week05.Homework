using System;
namespace Week05.Homework.Task3
{
    public class MyList<T>
    {
        //Variable to store the first available/unoccupied index 
        private int Count = 0;
        //Store the length of the array
        public int listSize { get; set; }
        //Create an array to store elements
        public T[] elements;
        //Construct the list
        public MyList(int size = 10)
        {
            //Get the list size
            listSize = size;
            //Set the list size
            elements = new T[listSize];
        }
        //Add an element to the first available index
        public void Add(T item)
        {
            //Assign the input
            elements[Count] = item;
            Count++;
            //Check and update the list size if the next element's index exceeds the list size
            if (Count >= listSize)
            {
                //Double the list size
                listSize *= 2;
            }
        }
        //Contains
        public bool Contains(T item)
        {
            //Loop to find a match
            foreach (var element in elements)
            {
                //Check if the item matches the current element
                if (item.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        //Remove first occurance of an item
        public void Remove(T item)
        {
            //check if the item exists
            if (Contains(item))
            {
                //find the element to remove
                for (int i = 0; i < listSize - 1; i++)
                {
                    if (elements[i].Equals(item))
                    {
                        //Empty the index
                        elements[i] = default(T);
                        //Decrement the number of elements
                        Count--;
                        //Loop to update indexes of rest of the elements
                        for (int j = i; j <= Count; j++)
                        {
                            //Check if the current element is the last one
                            if (j + 1 > Count)
                            {
                                elements[j] = default(T);
                                return;
                            }
                            //Move each remaining element up in the list by one index
                            elements[j] = elements[j + 1];
                        }
                        return;
                    }
                }
            }
            else
            {
                //Print out the error message
                Console.WriteLine($"{item} doesn't exist in the list!!!");
            }
        }
        //Clear the list
        public void Clear()
        {
            //Loop to assign each element to a default value
            for (int i = 0; i < Count; i++)
            {
                elements[i] = default(T);
            }
            //Empty the array
            elements = new T[0];
        }
        //Iteration
        public T[] GetValues()
        {
            return elements;
        }
        //Number of elements
        public int GetCount()
        {
            return Count;
        }
    }
}

