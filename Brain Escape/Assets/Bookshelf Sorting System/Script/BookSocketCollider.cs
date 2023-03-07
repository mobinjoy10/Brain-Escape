using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BookSocketCollider : MonoBehaviour
{
    [SerializeField] BookSortingPuzzleManager puzzleManager;
    [SerializeField] private GameObjectType bookObjectType;

    private void OnTriggerEnter(Collider other)
    {
        PuzzleBookComponent bookComponent = other.GetComponent<PuzzleBookComponent>();
        if (bookComponent.Equals(null)) return;

        if (bookComponent.colliderObjectType.Equals(bookObjectType))
        {
            puzzleManager.sortedBookCount++;
            
            
            if (puzzleManager.sortedBookCount.Equals(puzzleManager.maxSortedBookCount))
            {
                //ALL BOOKS ARE IN THE CORRECT ORDER. PUZZLE COMPLETED SUCCESSFULLY! CALL RELEVANT EVENTS HERE!
                Debug.Log("PUZZLE COMPLETED!");
                puzzleManager.OnPuzzleCompleted?.Invoke();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PuzzleBookComponent bookComponent = other.GetComponent<PuzzleBookComponent>();
        if (bookComponent.Equals(null)) return;

        if (bookComponent.colliderObjectType.Equals(bookObjectType))
        {
            // ONE BOOK REMOVED FROM THE RIGHT SOCKET.
            puzzleManager.sortedBookCount--;
        }
    }
}
