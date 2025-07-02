﻿public static int Clamp(int value, int minValue,  int maxValue)
{
    if(value < minValue)
        return minValue;

    if(value > maxValue)
        return maxValue;

    return value;
}