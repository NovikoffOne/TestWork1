using TMPro;
using UnityEngine;

namespace Assets.Code
{
    public class GameOverPanel : ResultPanel
    {
        [SerializeField] private TMP_Text _result;

        public TMP_Text Result => _result;
    }
}
