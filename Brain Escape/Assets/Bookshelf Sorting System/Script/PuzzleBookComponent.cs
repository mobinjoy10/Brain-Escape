using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBookComponent : MonoBehaviour
{
    public static HashSet<PuzzleBookComponent> PuzzleBooks { get; private set; } = new HashSet<PuzzleBookComponent>();

    [SerializeField] private BookSortingPuzzleManager puzzleManager;
    [field: SerializeField] public int bookIndex { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        BookSocketCollider bookSocketCollider = other.GetComponent<BookSocketCollider>();
        if (bookSocketCollider.Equals(null)) return;
        PuzzleBooks.Add(this);

        /*bool isInCorrectOrder = puzzleManager.PerformCheck();
        
        if (isInCorrectOrder)
        {
            Debug.Log("Puzzle Completed!");
            puzzleManager.OnPuzzleCompleted?.Invoke();
        }
        */
    }

    private void OnTriggerExit(Collider other)
    {
        BookSocketCollider bookSocketCollider = other.GetComponent<BookSocketCollider>();
        if (bookSocketCollider.Equals(null)) return;
        PuzzleBooks.Remove(this);
    }

    private void OnDisable()
    {
        PuzzleBooks.Remove(this);
    }

}
