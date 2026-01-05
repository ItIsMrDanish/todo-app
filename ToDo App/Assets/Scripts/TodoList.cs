using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TodoList : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button addButton;
    public Transform contentArea;
    public GameObject taskPrefab;

    public void AddTask()
    {
        string taskText = inputField.text;
        if (string.IsNullOrWhiteSpace(taskText)) return;

        Debug.Log($"Input: {inputField}, Content: {contentArea}, Prefab: {taskPrefab}");
        GameObject newTask = Instantiate(taskPrefab, contentArea);
        newTask.GetComponentInChildren<TMP_Text>().text = taskText;
        inputField.text = "";
    }
}
