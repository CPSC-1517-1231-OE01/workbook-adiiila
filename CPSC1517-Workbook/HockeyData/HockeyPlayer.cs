using Utils;

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
        private int _weightInPounds;

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

        public string FirstName 
        { 
            get
            {
                return _firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }

                _lastName = value;
            }
        }

        public int HeightInInches
        { 
            get
            {
                return _heightInInches; 
            }
            set
            {
                if(Utilities.IsZeroOrNegative(value))
                {
                    throw new ArgumentException("Height must be positive.");
                }

                _heightInInches = value;
            }
        }

        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }

            set
            {
                if (!Utilities.IsPositive(value))
                //OR could do (Utilities.IsPositive(value) == false)
                //OR could do (Utilities.IsPositive(value) == false)
                {
                    throw new ArgumentException("Weight must be positive.");
                }

                _weightInPounds = value;
            }
        }
        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            { 
                if (Utilities.IsInTheFuture(value))
                {
                    throw new ArgumentException("Date cannot be in the future.");
                }
                
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
            _weightInPounds = 0;
            _heightInInches = 0;
            Shot = Shot.Left;
            Position = Position.Center;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthPlace"></param>
        /// <param name="dateofBirth"></param>
        /// <param name="weightInPounds"></param>
        /// <param name="heightInInches"></param>
        /// <param name="position"></param>
        /// <param name="shot"></param>
        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly dateofBirth,
            int weightInPounds, int heightInInches, Position position = Position.Center, Shot shot = Shot.Left)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthPlace = birthPlace;
            WeightInPounds = weightInPounds;
            HeightInInches = heightInInches;
            DateOfBirth = dateofBirth;
            Position = position;
            Shot = shot;
        }

    }
}