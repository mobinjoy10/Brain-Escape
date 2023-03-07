using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "New Object Type", menuName = "Scriptable Object/Object Type")]
public class GameObjectType : ScriptableObject
{
    [field:SerializeField] public string objectName { get; private set; }
}
