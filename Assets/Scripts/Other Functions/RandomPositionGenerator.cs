using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositionGenerator
{
    private float _screenWidth;
    private float _screenHeight;
    private float _screenSpawnOffset;

    public RandomPositionGenerator(float screenWidth, float screenHeight, float spawnOffset)
    {
        _screenHeight = screenHeight;
        _screenWidth = screenWidth;
        _screenSpawnOffset = spawnOffset;
    }
    public Vector3 GetBoundriesPosition()
    {
        return HorizontalOrVertical();
    }
    private float BorderValue(float hightOrWidth)
    {
        float value = (hightOrWidth / 2) - _screenSpawnOffset;
        return value;
    }
    private Vector3 HorizontalOrVertical()
    {
        Vector3 position = new Vector3(0, 0, 0);
        if (Random.Range(0, 2) == 0)
        {
            position.x = Random.Range(-BorderValue(_screenWidth), BorderValue(_screenWidth));
            position = IsPositiveValue(position);
            return position;
        }
        else
        {
            position.y = Random.Range(-BorderValue(_screenHeight), BorderValue(_screenHeight));
            position = IsPositiveValue(position);
            return position;
        }
    }
    private Vector3 IsPositiveValue(Vector3 value)
    {
        Vector3 position = value;

        float[] HorizontalValues = new float[2];
        HorizontalValues[0] = -BorderValue(_screenHeight);
        HorizontalValues[1] = BorderValue(_screenHeight);
        
        float[] VerticalValues = new float[2];
        VerticalValues[0] = -BorderValue(_screenWidth);
        VerticalValues[1] = BorderValue(_screenWidth);

        if (position.x == 0)
        {
            position.x = VerticalValues[Random.Range(0,2)];
        }
        else
        {
            position.y = HorizontalValues[Random.Range(0, 2)];
        }
        return position;
    }

}
