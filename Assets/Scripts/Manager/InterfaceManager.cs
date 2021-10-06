using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private Button joinPlayerOne;

    [SerializeField]
    private Button joinPlayerTwo;

    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;
    // Start is called before the first frame update
    void Start()
    {
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());
        joinPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());
    }

    private void JoinPlayerOne()
    {
        playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
        joinPlayerOne.GetComponentInChildren<Text>().text = "Leave Player One";
        joinPlayerOne.onClick.RemoveListener(JoinPlayerOne);
        joinPlayerOne.onClick.AddListener(() => LeavePlayerOne());
    }
    private void LeavePlayerOne()
    {
        playerInputManager.LeavePlayer(0);
    }

    private void JoinPlayerTwo()
    {
        playerInputManager.JoinPlayer(1, "PlayerTwo");
        joinPlayerTwo.GetComponentInChildren<Text>().text = "Leave Player Two";
        joinPlayerTwo.onClick.RemoveListener(JoinPlayerTwo);
        joinPlayerTwo.onClick.AddListener(() => LeavePlayerTwo());
    }
    private void LeavePlayerTwo()
    {
        playerInputManager.LeavePlayer(1);
    }
}
