using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifaer : MonoBehaviour
{
    [SerializeField] int _width;
    [SerializeField] int _height;

    float _widthMultiplayer = 0.00005f;
    float _heightMultiplayer = 0.001f;

    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;

    [SerializeField] Renderer _renderer;

    [SerializeField] Transform _colliderTransform;



    void Update()
    {
        float offSetY = _height * _heightMultiplayer + 0.17f;

        _topSpine.position = _bottomSpine.position + new Vector3(0, offSetY, 0);

        _colliderTransform.localScale = new Vector3(1, 1.84f + _height * _heightMultiplayer, 1);


        if (Input.GetKey(KeyCode.W))
        {
            AddWigth(20);
        }
        if (Input.GetKey(KeyCode.S))
        {
            AddHeight(20);
        }
    }

    public void AddWigth(int value)
    {
        _width += value;
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplayer);
    }

    public void AddHeight(int value)
    {
        _height += value;
    }
}
