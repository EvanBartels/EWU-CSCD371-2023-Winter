namespace ClassDemo
{
    public class Vehicle
    {
        private string _Model;

        public string Model { 
            get
            { 
                return _Model; 
            }
            set 
            {
                //ArgumentNullException.ThrowIfNull(value);
                if (value is null) 
                {
                    throw new ArgumentNullException(nameof(value)); 
                }
                _Model = value; 
            }
        }
    }
}