using System.Data;
using System.Net.NetworkInformation;

namespace Taller01.Backend;

public class Time
{
    private int _hour;
    private int _minute;
    private int _second;
    private int _milisecond;

    public Time()
    {
        _hour = 0;
        _minute = 0;
        _second = 0;
        _milisecond = 0;
    }

    public Time(int hour)
    {
        Hour = hour;
        Minute = 0; 
        Second = 0;
        Milisecond = 0;
    }

    public Time(int hour, int minute)
    {
        Hour= hour;
        Minute= minute;
        Second= 0;
        Milisecond = 0;
    }

    public Time(int hour, int minute, int second, int milisecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Milisecond = milisecond;
    }

    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Milisecond = 0;
    }

    public int Hour 
    { 
        get => _hour; 
        set => _hour = ValidateHour(value); 
    }

    public int Minute
    {
        get => _minute;
        set => _minute = ValidateMinute(value);
    }
    public int Second
    {
        get => _second;
        set => _second = ValidateSecond(value);
    }
    public int Milisecond
    {
        get => _milisecond;
        set => _milisecond = ValidateMilisecond(value);
    }

    public long ToMilliseconds()
    {   
        long Calculatedmilisecond = Milisecond + 1000 * Second + 60000 * Minute + 3600000 * Hour;
        return Calculatedmilisecond;
    }

    public long ToSeconds()
    {
        long CalculatedSecond = Second + 60 * Minute + 3600 * Hour;
        return CalculatedSecond;
    }

    public long ToMinutes()
    {
        long Calculatedminute = Minute + 60 * Hour;
        return Calculatedminute;
    }

    public bool IsOtherDay(Time t) 
    {
        int Calculatedday = 3600000*(Hour + t.Hour) + 60000*(Minute + t.Minute) + 1000*(Second + t.Second) + (Milisecond + t.Milisecond);
        return Calculatedday >= 86400000;
    }

    public Time Add(Time t)
    {

        int calculatedmilliseconds =3600000 * (Hour + t.Hour) + 60000 * (Minute + t.Minute) + 1000 * (Second + t.Second) + (Milisecond + t.Milisecond);
        int newhour = calculatedmilliseconds/3600000;
        if (newhour >= 24)
        {
            newhour = newhour % 24;
        }
        int restmillisecond = (calculatedmilliseconds % 3600000);
        int newminute = restmillisecond / 60000;
        int restmillisecond1 = (restmillisecond % 60000);
        int newsecond = restmillisecond1 / 1000;
        int newmillisecond = (restmillisecond1 % 1000);
        return new Time(newhour, newminute, newsecond, newmillisecond);
    }

   
    public override string ToString()
    {
        int DisplayHour = _hour;
        string tt = "AM";

        if (_hour == 0)
        {
            DisplayHour = 12;
            tt = "AM";
        }
       
        else if (_hour == 12)
        {
            tt = "PM";
        }
        else if (13 <= _hour && _hour <= 23)
        {
            DisplayHour -= 12;
            tt = "PM";
        }
        return $"{DisplayHour:00}:{Minute:00}:{Second:00}.{Milisecond:000} {tt}";
    }

    private int ValidateHour(int hour)
    {   
        if (hour < 0 || hour > 23)
        {
            throw new Exception ($"The Hour {hour} is not valid");
        }
        return hour;
        
    }

    private int ValidateMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new ArgumentOutOfRangeException(nameof(minute), $"The Minute {minute} must be between 0 and 59");
        }
        return minute;
    }

    private int ValidateSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new ArgumentOutOfRangeException(nameof(second), "Second must be between 0 and 59");
        }
        return second;
    }

    private int ValidateMilisecond(int milisecond)
    {
        if (milisecond < 0 || milisecond > 999)
        {
            throw new ArgumentOutOfRangeException(nameof(milisecond), "Milisecond must be between 0 and 999");
        }
        return milisecond;
    }

    


        
}
