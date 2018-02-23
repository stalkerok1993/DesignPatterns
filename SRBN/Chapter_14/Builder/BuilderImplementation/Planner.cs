namespace BuilderImplementation {
    class Planner : APlanner {
        public string Email { get; }

        public Planner(string name, string email) : base(name) {
            Email = email;
        }
    }
}
