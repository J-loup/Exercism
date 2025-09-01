using System.Globalization;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{

    public static TimeZoneInfo getTimeZone(Location location)
    {
        String id = "";
        switch(location)
        {
        case Location.NewYork:
            id = "Eastern Standard Time";
            break;
        case Location.London:
            id = "GMT Standard Time";
            break;
        case Location.Paris:
            id = "Romance Standard Time";
            break;
        }

        return TimeZoneInfo.FindSystemTimeZoneById(id);
    }
    
    public static DateTime ShowLocalTime(DateTime dtUtc)
    {
        return TimeZoneInfo.ConvertTimeToUtc(dtUtc);
    }

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        return TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription),
                                             getTimeZone(location));
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        String time = "";
        switch(alertLevel)
        {
        case AlertLevel.Early:
            time = "1.00:00:00";
            break;
        case AlertLevel.Standard:
            time = "01:45:00";
            break;
        case AlertLevel.Late:
            time = "00:30:00";
            break;
        }
        TimeSpan timespan = TimeSpan.Parse(time);
        return appointment - timespan;
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        TimeZoneInfo.AdjustmentRule[] rules = getTimeZone(location).GetAdjustmentRules();
        TimeSpan delta = TimeSpan.Parse("7.00:00:00");
        foreach (var rule in rules)
        {
            if(rule.DaylightDelta != TimeSpan.Zero && dt >= rule.DateStart && dt <= (rule.DateEnd + delta))
            {
                return true;
            }   
        }

        return false;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        string format = "";
        switch(location)
        {
        case Location.NewYork:
            format = "MM/dd/yyyy HH:mm:ss";
            break;
        case Location.London:
            goto case Location.Paris;  // Fallthrough
        case Location.Paris:
            format = "dd/MM/yyyy HH:mm:ss";
            break;
        }

        DateTime result;
        try {
            result = DateTime.ParseExact(dtStr, format, CultureInfo.InvariantCulture);
        }
        catch (FormatException) {
            result = new DateTime(1,1,1);
        }

        return result;
    }
}
