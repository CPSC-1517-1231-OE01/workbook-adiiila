namespace Hockey.Data
{
    public class HockeyPlayer
    {
        // data fields
        private string _firstName;
        private string _lastName;
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private int _heightInInches;
        private int _weightInInches;

        //We dont need the following
        //private Position _position;
        //private Shot _shot;

        // properties
        public string BirthPlace
        {
            get
            {
                return _birthPlace;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value)) 
                {
                    throw new ArgumentException("Birth place cannot be null or empty.");                
                }

                //if we get here, then no exception happened
                _birthPlace = value;
            }

        }

        //TODO: complete the remaining string properties for homework
        public int HeightInInches
        { 
            get
            {
                return _heightInInches; 
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Height must be positive.");
                }

                _heightInInches = value;
            }
        }

        // TODO: complete the remaining int property
        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            { 
                // TODO: implement a valididy check for dates in the future
                // Check the documentation for DateOnly
                _dateOfBirth = value;
            }
        }

        // Auto-implemented properties (they dont need fields)
        // you use auto impletned propeties when you have no logic to apply to getting and setting
        public Position Position { get; set; }

        /// <summary>
        /// Represents the shot hand for the player
        /// </summary>
        public Shot Shot { get; set; }

        // constructors
        // they are different from redgular methods because they don't need a return type and takes no parameters


        /// <summary>
        /// Creates a default instance of a hockey player
        /// </summary>
        public HockeyPlayer()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthPlace = string.Empty;
            _dateOfBirth = new DateOnly();
            _weightInInches = 0;
            _heightInInches = 0;
            Shot = Shot.Left;
            Position = Position.Center;
        }

        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly dateofBirth,
            int weightInPounds, int heightInInches, Position position = Position.Center, Shot shot = Shot.Left)
        {
            BirthPlace = birthPlace;
            HeightInInches = heightInInches;
            Position = position;
            Shot = shot;
            //TODO: assign the remaining properties once you've completed them
        }

    }
}