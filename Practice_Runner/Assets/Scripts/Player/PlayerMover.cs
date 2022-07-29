using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;
    [SerializeField] private float _minWidth;
    [SerializeField] private float _maxWidth;

    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
    }

    internal void TryMoveRight()
    {
        if (_targetPosition.x < _maxWidth)
            SetLeftRightPosition(_stepSize);
    }

    internal void TryMoveLeft()
    {
        if (_targetPosition.x > _minWidth)
            SetLeftRightPosition(-_stepSize);
    }

    public void TryMoveUp()
    {
        if (_targetPosition.y < _maxHeight)
            SetUpDownPosition(_stepSize);
    }

    public void TryMoveDown()
    {
        if (_targetPosition.y > _minHeight)
            SetUpDownPosition(-_stepSize);
    }

    private void SetUpDownPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
    }

    private void SetLeftRightPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x+stepSize,_targetPosition.y);
    }
}
