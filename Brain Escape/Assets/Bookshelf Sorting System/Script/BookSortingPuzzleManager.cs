using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "New Book Sorting Puzzle Manager", menuName = "Scriptable Object/Book Sorting Puzzle Manager")]

public class BookSortingPuzzleManager : PuzzleManager
{
    [field:SerializeField] public int maxSortedBookCount { get; private set; } = 5;
    public int sortedBookCount = 0;
    
}
