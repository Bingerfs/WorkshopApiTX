using System;

namespace BusinessLogic.models
{
    public class Workshop
    {
        public string Name { set; get; }

        public int Id { set; get; }

        private string _status;

        public string Status
        {
            set
            {
                _status = value;
            }
            get
            {
                return _status;
            }
        }
    }
}
