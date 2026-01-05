using UnityEngine;
using UnityEngine.UI;

public class TaskItem : MonoBehaviour
{
    public void DelTask()
    {
        Destroy(gameObject);
    }
}