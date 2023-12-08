using Assets.Code;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestionInstaller : MonoBehaviour
{
    [SerializeField] TMP_Text _question;
    [SerializeField] List<TMP_Text> _answersText;
    
    [SerializeField] Sprite _background;

    private Data[] _data;
    private int _index;

    private void Awake()
    {
        _data = new JsonFormatter().GetFormatData();
    }

    private void Start()
    {
        //_question.text = _data[0].question;
    }
}
