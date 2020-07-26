using System;

namespace BallGamesClassLibrary
{
    public class HitEventArgs : EventArgs
    {
        
            public HitType Type { get; }
            public HitEventArgs(HitType type)
            {
                Type = type;
            }
    }
}
