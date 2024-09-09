using System;
using System.Collections.Generic;

namespace SaveAndLoad
{
    [Serializable]
    public class GameData
    {
        public List<SingleData> saves;

    }

    [Serializable]
    public class SingleData
    {

        public string name;
        public int value;

    }
}