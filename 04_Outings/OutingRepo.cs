using System;
using System.Collections.Generic;
using _04_Outings;

namespace _Outings
{
    public class OutingRepo
    {
        public List<Outings> _listOfOutings = new List<Outings>();

        public List<Outings> GetListOfOutings()
        {
            return _listOfOutings;
        }

        public void AddContentToList(Outings content)
        {
            _listOfOutings.Add(content);
        }

    }
}
