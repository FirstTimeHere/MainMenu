using UnityEngine;
using UnityEngine.UI;

public class BackgroundChanger : MonoBehaviour
{
    [SerializeField] private Sprite[] _backgrounds;
    [SerializeField] private Image _panelImage;

    private int _selectedIndex = 0;
    public void ChangeBackground()
    {
        if (_selectedIndex >= _backgrounds.Length)
        {
            _selectedIndex = 0;
            _panelImage.sprite = _backgrounds[_selectedIndex];
        }

        _panelImage.sprite = _backgrounds[_selectedIndex];

        _selectedIndex++;
    }
}
