using System;

[Serializable]
public class Data
{
    public string question;
    public Answer[] answers;
    public string background;
}

[Serializable]
public class Answer
{
    public string text;
    public bool correct;
}
