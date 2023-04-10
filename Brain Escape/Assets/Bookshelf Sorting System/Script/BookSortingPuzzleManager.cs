using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class BookSortingPuzzleManager : PuzzleManager
{
    [SerializeField] private int maxBookCount = 5;
    public List<PuzzleBookComponent> sortedBookList;

    public int minimumIndex, maximumIndex;

    public DoorUnlockManager door;
    public bool PerformCheck()
    {
        

        if (!PuzzleBookComponent.PuzzleBooks.Count.Equals(maxBookCount)) return false;

        sortedBookList = PuzzleBookComponent.PuzzleBooks.OrderBy(t => t.transform.position.z).ToList();
        
        return sortedBookList
            .Select((book, index) => index == 0 || book.bookIndex >= sortedBookList[index - 1].bookIndex && book.bookIndex >= minimumIndex && book.bookIndex <= maximumIndex)
            .All(isInOrder => isInOrder);
    }

    private void Update()
    {
        
            bool sorted = PerformCheck();

            if (sorted)
            {
                if(door != null)
            {
                door.OpenDoor();
            }
            }
        
    }
}
