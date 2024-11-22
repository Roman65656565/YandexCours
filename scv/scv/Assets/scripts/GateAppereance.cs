using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType
{
    Width,
    Height
}

public class GateAppereance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    [SerializeField] Image _topImage;
    [SerializeField] Image _downImage;

    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;

    [SerializeField] GameObject _expendLable;
    [SerializeField] GameObject _srinkLable;

    [SerializeField] GameObject _upLable;
    [SerializeField] GameObject _downLable;

    public void UbdateVisual(DeformationType _deformationType, int value)
    {
        string prefix = "";

        if (value > 0)
        {
            SetColor(_colorPositive);
            prefix = "+";
        }
        else if(value == 0)
        {
            SetColor(Color.grey);
        }
        else
        {
            SetColor(_colorNegative);
        }

        _expendLable.SetActive(false);
        _upLable.SetActive(false);
        _downLable.SetActive(false);
        _srinkLable.SetActive(false);

        if (_deformationType == DeformationType.Height)
        {
            if (value > 0)
            {
                _upLable.SetActive(true);
            }
            else
            {
                _downLable.SetActive(true);
            }
        }
        else if (_deformationType == DeformationType.Width)
        {
            if (value > 0)
            {
                _expendLable.SetActive(true);
            }
            else
            {
                _srinkLable.SetActive(true);
            }
        }

        _text.text = prefix + value.ToString();
    }


    private void SetColor(Color _color)
    {
        _topImage.color = _color;
        _downImage.color = new Color(_color.r, _color.g, _color.b, 0.6f);
    }
}
