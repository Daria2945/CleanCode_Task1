public static int Clamp(int value, int minValue,  int maxValue)
{
    if(minValue >= maxValue)
        throw new ArgumentException($"Аргумент {nameof(minValue)} не может быть больше или равен {nameof(maxValue)}")

    if (value < minValue)
        return minValue;

    if(value > maxValue)
        return maxValue;

    return value;
}