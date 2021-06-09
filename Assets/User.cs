using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class User
{
    public string username;
    public string userscore;

    public User()
    {
        username = SaveButton.user;
        userscore = ButtonClick.result;
    }
}
