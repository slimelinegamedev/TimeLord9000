public delegate void Callback();
public delegate void Callback<T>(T arg1);
public delegate void Callback<T, U>(T arg1, U arg2);
public delegate void Callback<T, U, V>(T arg1, U arg2, V arg3);

public enum EVENTID
{
    EVENT_REWIND_TIME,
    //Use this to count number of events
    COUNT,
}

public enum MANIPULATION_TYPE
{
    NONE,
    REWIND,
    PAUSE,
}
