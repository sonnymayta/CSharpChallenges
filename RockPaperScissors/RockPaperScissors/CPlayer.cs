namespace RockPaperScissors
{
    internal class CPlayer
    {
        private State _state;

        public string Name { get; }

        public State State 
        {
            get => _state;
        }

        public CPlayer(string name, State state)
        {
            Name = name;
            _state = state;
        }

        public CPlayer() : this ("none", State.Undefined) { }

        public void SetState()
        {
            Random random = new();
            int number = random.Next(1, 3);
            switch (number)
            {
                case 1:
                    _state = State.Rock; 
                    break;
                case 2:
                    _state = State.Paper;
                    break;
                case 3:
                    _state = State.Scissor;
                    break;
                default:
                    _state = State.Undefined;
                    break;
            }
        }
    }    
}
