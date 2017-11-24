namespace SimpleSingletone
{
    class Singletone {
        private static Singletone instance;

        private Singletone() {
        }

        public static Singletone Instance {
            get {
                return instance ?? (instance = new Singletone());
            }
        }

        public string Name {
            get {
                return "I'm the only one, I-I-I-I!";
            }
        }
    }
}
