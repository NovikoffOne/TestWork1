using System;
using System.Collections.Generic;


[Serializable]
public class Data
{
    public string question;
    public List<Answer> answers;
    public string background;
}


[Serializable]
public class Answer
{
    public string text;
    public bool correct;
}
