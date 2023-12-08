using System.Collections.Generic;
using TMPro;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code
{
    public class QuestionPanel : MonoBehaviour
    {
        [SerializeField] private TMP_Text _question;
        [SerializeField] private List<Button> _answersButtons;
        [SerializeField] private List<TMP_Text> _answersTexts;
        [SerializeField] private Image _background;

        public TMP_Text Question => _question;
        public List<Button> AnswersButtons => _answersButtons;
        public List<TMP_Text> AnswersTexts => _answersTexts;
        public Image Background => _background;
    }
}
